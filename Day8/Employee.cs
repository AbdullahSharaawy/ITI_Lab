using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Employee
    {
        public static int ECounter;// to make the id increamenter
        private int _ID;
        private decimal _Salary;
        private string _Name;
        private int _DeptID;
		private DateTime _DB;
        public int DeptID { get { return _DeptID; } set { _DeptID = value; } }
        public int ID
        {
            get { return _ID; }
           private set { _ID = value; }
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

		
		public Employee(string Name, decimal Salary, DateTime DB, int DeptID)
		{
			ID = ECounter;
			_Name = Name;
			_Salary = Salary;
			_DB = DB;
			_DeptID = DeptID;
            WorksOn = new List<WorksOn>();
		}
		public List<WorksOn> WorksOn { get; private set; }
	}

}
