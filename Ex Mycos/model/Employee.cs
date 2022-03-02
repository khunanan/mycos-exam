using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Mycos.model
{
    public class Employee
    {


        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        public double PvdRate3to12 { get; set; }
        public double PvdRate12to36 { get; set; }
        public double PvdRate36to60 { get; set; }
        public double PvdRateOver60 { get; set; }
        public Employee(int v, string name, string lastName, DateTime dateBirth, DateTime startDate, int sal, double pvdRate3_12_value, double pvdRate12_36_value, double pvdRate36_60_value, double pvdRateEfter_value)
        {
            id = v;
            FirstName = name;
            LastName = lastName;
            BirthDate = dateBirth;
            StartDate = startDate;
            Salary = sal;
            PvdRate3to12 = pvdRate3_12_value;
            PvdRate12to36 = pvdRate12_36_value;
            PvdRate36to60 = pvdRate36_60_value;
            PvdRateOver60 = pvdRateEfter_value;
        }
    }
}
