using System;
using System.Data;
using System.Windows.Forms;
using Ex_Mycos.model;
using MySql.Data.MySqlClient;


namespace Ex_Mycos
{
    public partial class Home : Form
    {
        MySqlConnection Con;
        int id = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewEmployee().Show();
        }

        void loadData()
        {
            Console.WriteLine($"StartLoadData");

            Con.Open();
            var sql = "SELECT * FROM employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            tbDataGrid.DataSource = table;
            Con.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var str = "server=localhost;userid=zero;password=;database=db_mysql";
            Con = new MySqlConnection(str);
            loadData();
        }

        private void tbDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = "";
            var lastName = "";
            var dateBirth = "";
            var startDate = "";
            var sal = 0;
            double pvdRate3_12_value = 0.03;
            double pvdRate12_36_value = 0.05;
            double pvdRate36_60_value = 0.08;
            double pvdRateEfter_value = 0.12;

            var rowIndex = e.RowIndex;

            if (rowIndex < tbDataGrid.Rows.Count - 1)
            {
                if (rowIndex > -1)
                {
                    DataGridViewRow row = tbDataGrid.Rows[rowIndex];
                    var idValue = row.Cells[0].Value.ToString();
                    id = Convert.ToInt32(idValue);

                    name = row.Cells[1].Value.ToString();
                    lastName = row.Cells[2].Value.ToString();
                    dateBirth = row.Cells[3].Value.ToString();
                    startDate = row.Cells[4].Value.ToString();
                    sal = int.Parse(row.Cells[5].Value.ToString());
                    pvdRate3_12_value = double.Parse(row.Cells[6].Value.ToString()) / 100.0;
                    pvdRate12_36_value = double.Parse(row.Cells[7].Value.ToString()) / 100.0;
                    pvdRate36_60_value = double.Parse(row.Cells[8].Value.ToString()) / 100.0;
                    pvdRateEfter_value = double.Parse(row.Cells[9].Value.ToString()) / 100.0;

                    DateTime db = Convert.ToDateTime(dateBirth);
                    DateTime sd = Convert.ToDateTime(startDate);

                    Employee employee = new Employee(0, name, lastName, db, sd, sal, pvdRate3_12_value, pvdRate12_36_value, pvdRate36_60_value, pvdRateEfter_value);


                    var dateNow = DateTime.Now;
                    var dateWork = monthdiff(employee.StartDate, dateNow);

                    var call = calMyPvd(dateWork, employee);

                    int year = dateWork / 12;
                    MessageBox.Show($"Employee Information \r\n{name} {lastName} \r\n{year} Year {dateWork % 12} Month of experience \r\nTotal Provident Fund: {call}");
                }
            }
        }

        private int monthdiff(DateTime start, DateTime end)
        {
            var datework = ((12 * (start.Year - end.Year)) + start.Month - end.Month);
            var month = Math.Abs(datework);
            return month;
        }

        private double calMyPvd(int month, Employee emp)
        {
            var finalRes = 0.0;

            // 1. พนักงานที่ทำงานน้อยกว่า 3 เดือนจะไม่ได้รับเงินกองทุนสำรองเลี้ยงชีพ
            // 2. พนักงานที่ทำงานน้อยกว่า 1 ปี บริษัทจะจ่ายให้ 10% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 3%
            // 3. พนักงานที่ทำงานน้อยกว่า 3 ปี บริษัทจะจ่ายให้ 30% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 5%
            // 4. พนักงานที่ทำงานน้อยกว่าที่บริษัทอายุ 5 ปีจ่าย 50% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 8%
            // 5. พนักงานที่ทำงานเกินบริษัท 5 ปีจะจ่าย 80% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 12%

            var pvdRateOver3Less12 = emp.PvdRate3to12;
            var pvdRateOver12Less36 = emp.PvdRate12to36;
            var pvdRateOver36Less60 = emp.PvdRate36to60;
            var pvdRateOver60 = emp.PvdRateOver60;
            var remaining = month;

            if (month > 60)
            {
                //5. พนักงานที่ทำงานเกินบริษัท 5 ปีจะจ่าย 80% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 12%
                var over60Month = remaining - 60;
                var thisPvd = (emp.Salary * pvdRateOver60) * over60Month;
                var companyAddOnThis = (emp.Salary * 0.8) * over60Month;
                var totalPvdOfOver60 = thisPvd + companyAddOnThis;
                finalRes += totalPvdOfOver60;
                remaining -= over60Month;
                //("on over 60 month $finalRes call with $over60Month and remaining month $remaining");
            }

            if (month > 36)
            {
                //4. พนักงานที่ทำงานน้อยกว่าที่บริษัทอายุ 5 ปีจ่าย 50% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 8%
                var over36Less60 = remaining - 36;
                var thisPvd = (emp.Salary * pvdRateOver36Less60) * over36Less60;
                var companyAddOnThis = (emp.Salary * 0.5) * over36Less60;
                var totalPvdOfOver36Less60 = thisPvd + companyAddOnThis;
                finalRes += totalPvdOfOver36Less60;
                remaining -= over36Less60;
                //("on over 36 less 60 month $finalRes call with $over36Less60 and remaining month $remaining");

            }

            if (month > 12)
            {
                //3. พนักงานที่ทำงานน้อยกว่า 3 ปี บริษัทจะจ่ายให้ 30% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 5%
                var over12Less36 = remaining - 12;
                var thisPvd = (emp.Salary * pvdRateOver12Less36) * over12Less36;
                var companyAddOnThis = (emp.Salary * 0.3) * over12Less36;
                var totalPvdOfOver36Less60 = thisPvd + companyAddOnThis;
                finalRes += totalPvdOfOver36Less60;
                remaining -= over12Less36;
                //("on over 12 less 36 month $finalRes call with $over12Less36 and remaining month $remaining");

            }

            if (month > 3)
            {
                //. พนักงานที่ทำงานน้อยกว่า 1 ปี บริษัทจะจ่ายให้ 10% และสามารถเลือกอัตรา pvd ได้ไม่เกิน 3%
                var over3Less12 = remaining - 3;
                var thisPvd = (emp.Salary * pvdRateOver3Less12) * over3Less12;
                var companyAddOnThis = (emp.Salary * 0.1) * over3Less12;
                var totalPvdOfOver36Less60 = thisPvd + companyAddOnThis;
                finalRes += totalPvdOfOver36Less60;
                remaining -= over3Less12;
                //("on over 3 less 12 month $finalRes call with $over3Less12 and remaining month $remaining");
            }

            var result = finalRes;

            return result;
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
