using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    public class System
    {
        Employee[] employees;
        int Count = 0;
        public System(int Size)
        {
            employees = new Employee[Size];
        }
        private string ReadName()
        {
            string Name;
            do
            {
                Console.Write("Please Enter Employee Name: ");
                Name = Console.ReadLine();

            } while (string.IsNullOrEmpty(Name));
            return Name;
        }
        private decimal ReadSalary()
        {
            decimal Salary;
            do
            {
                Console.Write("Please Enter Employee Salary: ");

            } while (!decimal.TryParse(Console.ReadLine(), out Salary));
            return Salary;
        }
        private DateTime ReadDate()
        {
            DateTime DB;
            do
            {
                Console.Write("Please Enter Date Of Birth dd-mm-yyyy: ");

            } while (!DateTime.TryParse(Console.ReadLine(), out DB));
            return DB;
        }
        public void AddEmployee()
        {
            Count++;
            string Name;
            decimal Salary;
            DateTime DB;
            Name = ReadName();
            Salary = ReadSalary();
            DB= ReadDate();
            employees[Employee.Counter]=new Employee(Employee.Counter++,Name, Salary, DB);
        }
        public void GetAllEmployee()
        {
            
            Console.WriteLine("list of Employees: ");
            Console.WriteLine();
            for (int i=0;i<Count;i++)
            {
                Console.WriteLine($"ID: {employees[i].ID} , Name: {employees[i].Name} , Salary: {employees[i].Salary} , Date Of Birth: {employees[i].DB}");
            }
            Console.WriteLine();
        }
        public void ShowEmployeeByID(int ID)
        {
            
            for (int i = 0; i < Count; i++) 
            {
                if(employees[i].ID == ID)
                {
                    Console.WriteLine($"ID: {employees[i].ID} , Name: {employees[i].Name} , Salary: {employees[i].Salary} , Date Of Birth: {employees[i].DB}");
                    Console.WriteLine();
                    break;
                }
            }
        }
        private Employee GetEmployeeByID(int ID)
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
                            string Name = ReadName();
                            employee.Name = Name;
                            break;
                        }
                            case 2:
                        {
                            decimal Salary = ReadSalary();
                            employee.Salary=Salary;
                            break;
                        }
                            case 3:
                        {
                            DateTime DB = ReadDate();
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
            Console.WriteLine("4-Exist");
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

