using Day8;
using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day9
{
	public class DepartmentBL
	{
		private Department[] departments;
		public DepartmentBL(int length)
		{
			departments = new Department[length];
		}
		public void AssignEmployee(Employee E)
		{
			for (int i = 0; i < departments.Count(); i++)
			{
				if(E.DeptID==departments[i].ID)
				{
					departments[i].Employees.Add(E); // Add employee to the department's employee list
					return; // Exit after assigning the employee
				}
			}
		}
		public void AssignProject(Project P)
		{
			for (int i = 0; i < departments.Count(); i++)
			{
				if (P.DeptID == departments[i].ID)
				{
					departments[i].Projects.Add(P); // Add employee to the department's employee list
					return; // Exit after assigning the employee
				}
			}
		}
		private Department CreateDepartment()
		{
			string name = ReadMethods.ReadString("Please Enter Department Name: ");
			string description = ReadMethods.ReadString("Please Enter Department Description: ");
			string location = ReadMethods.ReadString("Please Enter Department Location: ");



			return new Department(name, description, location);
		}
		 public void DisplayDepartment(Department department)
		{
			Console.WriteLine($"ID: {department.ID}");
			Console.WriteLine($"Name: {department.Name}");
			Console.WriteLine($"Description: {department.Description}");
			Console.WriteLine($"Location: {department.Location}");
			Console.WriteLine("Employees:");
			foreach (var employee in department.Employees)
			{
				Console.WriteLine($"Employee Name: {employee.Name} ,Employee ID: {employee.ID}");
			}
			Console.WriteLine("Projects:");
			foreach (var project in department.Projects)
			{
				Console.WriteLine($"Project Name: {project.Name} ,Project ID: {project.Id}");
			}
		}
		static public void UpdateDepartment(ref Department department)
		{

			if (department == null) return;
			byte choice = 0;
			while (choice != 4)
			{

				do
				{
					Console.Write("1-Name , 2-Description , 3-Location , 4-Back: ");

				} while (!byte.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4));

				switch (choice)
				{

					case 1:
						{
							string Name = ReadMethods.ReadString("Please Enter Employee Name: "); ;
							department.Name = Name;
							break;
						}
					case 2:
						{
							string Description = ReadMethods.ReadString("Please Enter Department Description: ");
							department.Description = Description;
							break;
						}
					case 3:
						{
							string Location = ReadMethods.ReadString("Please Enter Department Location: ");
							department.Location = Location;
							break;
						}

				}

			}
		}
		static public void DeleteDepartment(ref Department department)
		{
			if (department == null) return;
			department = null; // Set to null to delete the reference
			Console.WriteLine("Department deleted successfully.");
		}
		
		private void PrintMainMenu()
		{
			Console.WriteLine("");
			Console.WriteLine("1-Add Department");
			Console.WriteLine("2-Get All Departments");
			Console.WriteLine("3-Show Department By ID");
			Console.WriteLine("4-Update Department");
			Console.WriteLine("5-Exist");
		}
		private void GetAllDepartments()
		{

			Console.WriteLine("list of Departments: ");
			Console.WriteLine();
			for (int i = 0; i < Department.DCounter; i++)
			{
				DisplayDepartment(departments[i]);
			}
			Console.WriteLine();
		}
		private Department GetDepartmentByID(int id)
		{
			for (int i = 0; i < departments.Count(); i++)
			{
				if (departments[i].ID == id)
				{
					return departments[i];
				}
			}
			return null;
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
							departments[Department.DCounter++] = CreateDepartment();
							break;
						}
					case 2:
						{
							Console.Clear();
							GetAllDepartments();
							break;
						}
					case 3:
						{
							Console.Clear();
							ID = ReadMethods.Readint("Enter The Department ID: ");
							var p = GetDepartmentByID(ID);
							DisplayDepartment(p);
							break;
						}
					case 4:
						{
							Console.Clear();
							ID = ReadMethods.Readint("Enter The Project ID: ");
							var p = GetDepartmentByID(ID);
							if (p != null)
								UpdateDepartment(ref p);
							else
								Console.WriteLine("Project not found.");
							break;
						}

				}
			}
		}
	}
}
