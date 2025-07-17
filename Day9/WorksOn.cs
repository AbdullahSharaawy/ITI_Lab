using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class WorksOn
    {
        public static int WCounter;// to make the id increamenter

        public WorksOn(int projectID, int employeeID)
        {
            _ProjectID = projectID;
            _EmployeeID = employeeID;
            _ID=WCounter;
        }

        private int _ID;
        private int _ProjectID;
        private int _EmployeeID;
        public int ID {  get=>_ID; }
        public int ProjectID {  get=>this._ProjectID;private set { this._ProjectID = value; } }
        public int EmployeeID {  get=>this._EmployeeID; set { this._EmployeeID = value; } }
    }
}
