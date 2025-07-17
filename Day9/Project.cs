using Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Project
    {
        public static int PCounter;// to make the id increamenter
        private int _ID;
        private string _Name;
        private string _Description;
        private DateTime _StartDate;
       
        private int? _DeptID;
		public List<WorksOn> WorksOn { get; private set; }
        
		public Project( string name, string description, DateTime startDate, int? deptID)
        {
            
            _Name = name;
            _Description = description;
            _StartDate = startDate;
            this._ID = PCounter; // Increment the counter and assign it to _ID
			_DeptID = deptID;
            WorksOn = new List<WorksOn>();
        }

        public int Id { get=>this._ID; }
        public string Name { get=>this._Name; set { this._Name = value; } }
        public string Description { get=>this._Description; set { this._Description = value; } }
        public DateTime StartDate { get=>this._StartDate;  }
         public int? DeptID {  get=>this._DeptID; set { this._DeptID = value; } }
		
	}
}
