using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Ex_Mycos
{
    public partial class NewEmployee : Form
    {
        MySqlConnection Con;

        public NewEmployee()
        {
            InitializeComponent();
        }

        public double pdv = 0.0;

        private void button1_Click(object sender, EventArgs e)
        {

            var name = txtname.Text;
            var lastname = txtlastname.Text;
            var datebirth = birth.Value;
            var startdate = startwork.Value;
            var sal = int.Parse(salary.Text);
            var pvdRate3_12_value = pvdRate3_12.Value;
            var pvdRate12_36_value = pvdRate12_36.Value;
            var pvdRate36_60_value = pvdRate36_60.Value;
            var pvdRateEfter_value = pvdRateAfter60.Value;



            Con.Open();
            var sql = "INSERT INTO employee(Name,LastName,Date_of_birth,Start_of_date,Salary,pvd_3_12,pvd_12_36,pvd_36_60,pvd_max)VALUES(@name,@lastname,@datebirth,@startdate,@sal,@pvdRate3_12_value,@pvdRate12_36_value,@pvdRate36_60_value,@pvdRateEfter_value)";
            MySqlCommand cmd = new MySqlCommand(sql, Con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@datebirth", datebirth);
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@sal", sal);
            cmd.Parameters.AddWithValue("@pvdRate3_12_value", pvdRate3_12_value);
            cmd.Parameters.AddWithValue("@pvdRate12_36_value", pvdRate12_36_value);
            cmd.Parameters.AddWithValue("@pvdRate36_60_value", pvdRate36_60_value);
            cmd.Parameters.AddWithValue("@pvdRateEfter_value", pvdRateEfter_value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Con.Close();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var str = "server=localhost;userid=root;password=;database=db_mysql";
            Con = new MySqlConnection(str);
        }
    }
}
