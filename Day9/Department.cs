using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8;
namespace Day9
{
   public class Department
    {
        public static int DCounter;// to make the id increamenter
        private string _Name;
        private string _Description;
        private string _Location;
        private int _ID;

        public Department(string name, string description, string location)
        {
            Name = name;
            Description = description;
            Location = location;
            ID = DCounter;
			Employees = new List<Employee>();
			Projects = new List<Project>();
		}

        public string Name { get=>this._Name; set{ this._Name = value; } }
        public string Description { get=>this._Description; set { this._Description = value; } }
        public string Location { get => this._Location; set { this._Location = value; } }
        public int ID { get => this._ID; private set => this._ID = value; }
        public List<Employee> Employees { get;private set; }
        public List<Project> Projects { get;private set; }
       
    }
}
