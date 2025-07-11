using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Employee
    {
        public static int Counter;// to make the id increamenter
        private int _ID;
        private decimal _Salary;
        private string _Name;
        private DateTime _DB;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public DateTime DB
        {
            get { return _DB; }
            set { _DB = value; }
        }
        public Employee(int ID,string Name, decimal Salary, DateTime DB)
        {
            _ID = ID;
            _Name = Name;
            _Salary = Salary;
            _DB = DB;
        }

    }

}
