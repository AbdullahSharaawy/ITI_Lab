using Day9;
using DaysCsharp;
using DaysCsharp.Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    public class EmployeeBL
    {
        Employee[] employees;
        public int Count
		{
			get
			{
				return Employee.ECounter;
			}
		}
		public EmployeeBL(int Size)
        {
            employees = new Employee[Size];
        }
        
        private void AddEmployee()
        {
            
            string Name;
            decimal Salary;
            DateTime DB;
            int DeptID,WorksOnID;
            Name = ReadMethods.ReadString("Please Enter Employee Name: ");
            Salary = ReadMethods.ReadDecimal("Please Enter Employee Salary: ");
            DB= ReadMethods.ReadDate("Please Enter Date of Birth dd-mm-yyyy: ");
			DeptID = ReadMethods.Readint("Please Enter Department ID: ");
			while (DeptID > Department.DCounter) 
			{
                Console.WriteLine();
                DeptID = ReadMethods.Readint("Please Enter a valid Department ID: ");
            } 


			employees[Employee.ECounter++]=new Employee(Name, Salary, DB,DeptID);
        }
        private void GetAllEmployee()
        {
            
            Console.WriteLine("list of Employees: ");
            Console.WriteLine();
            for (int i=0;i<Count;i++)
            {
                Console.WriteLine($"ID: {employees[i].ID} , Name: {employees[i].Name} , Salary: {employees[i].Salary} , Date Of Birth: {employees[i].DB} ");
            }
            Console.WriteLine();

        }
		public void AssignProject(WorksOn W)
		{
			for (int i = 0; i < employees.Count(); i++)
			{
				if (W.EmployeeID == employees[i].ID)
				{
					employees[i].WorksOn.Add(W); // Add employee to the department's employee list
					return; // Exit after assigning the employee
				}
			}
		}
		private void ShowEmployeeByID(int ID)
        {
            
            for (int i = 0; i < Count; i++) 
            {
                if(employees[i].ID == ID)
                {
                    Console.WriteLine($"ID: {employees[i].ID} , Name: {employees[i].Name} , Salary: {employees[i].Salary} , Date Of Birth: {employees[i].DB}");
                    Console.WriteLine();
					Console.WriteLine("this Emplyee is assigned to these Projects: ");
					foreach (var item in employees[i].WorksOn)
					{
						Console.WriteLine($"-Project ID: {item.ProjectID} ");
					}
					break;
                }
            }
        }
        public Employee GetEmployeeByID(int ID)
        {
            for (int i = 0; i < Count; i++)
            {
                if (employees[i].ID == ID)
                {
                    return employees[i];
                }
            }
            return null;
        }
        public void UpdateEmployee(int ID)
        {
            Employee employee = GetEmployeeByID(ID);
            if (employee == null) return;
            byte choice = 0;
            while (choice!=4)
                    {
                        
                do
                {
                    Console.Write("1-Name , 2-Salary , 3-Date Of Birth , 4-Back: ");

                } while (!byte.TryParse(Console.ReadLine(), out choice) || (choice<1 || choice>4));

                        switch (choice)
                        {
                            
                            case 1:
                        {
                            string Name = ReadMethods.ReadString("Please Enter Employee Name: "); ;
                            employee.Name = Name;
                            break;
                        }
                            case 2:
                        {
                            decimal Salary = ReadMethods.ReadDecimal("Please Enter Employee Salary: ");
							employee.Salary=Salary;
                            break;
                        }
                            case 3:
                        {
                            DateTime DB = ReadMethods.ReadDate("Please Enter Date of Birth dd-mm-yyyy: ");
							employee.DB = DB;
                            break;
                        }

                        }
                            
                            
                        
                    }
            
        }
        private void PrintMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1-Add Employee");
            Console.WriteLine("2-Get All Employee");
            Console.WriteLine("3-Show Employee By ID");
            Console.WriteLine("4-Update Employee");
            Console.WriteLine("5-Exist");
        }
        private int ReadID() 
        {
            int ID;
            do
            {
                Console.Write("Enter Employee ID: ");
            }while(!int.TryParse(Console.ReadLine(),out ID));
            return ID;
        }
        public void Run()
        {
            Console.Clear();

            byte choice = 0;
            int ID;
            while (choice != 5)
            {
                

                do
                {
                    PrintMainMenu();

                } while (!byte.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 5));

                switch (choice)
                {

                    case 1:
                        {
                            Console.Clear();
                            AddEmployee();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            GetAllEmployee();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            ID = ReadID();
                            ShowEmployeeByID(ID);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            ID = ReadID();
                            UpdateEmployee(ID);
                            break;
                        }

                }



            }


        }
    }
}

