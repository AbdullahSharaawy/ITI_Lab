using Day8;
using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day9
{
	public class StartProgram
	{
		public WorksOnBL EmployeesProjects { get; private set; }
		public EmployeeBL Employees { get; private set; }
		public ProjectBL Projects { get; private set; }
		public DepartmentBL Departments { get; private set; }

		public StartProgram()
		{
			EmployeesProjects = new WorksOnBL(100);
			Employees = new EmployeeBL(100);
			Projects = new ProjectBL(100);
			Departments = new DepartmentBL(100);
		}
        private void MainMenu()
		{
			Console.WriteLine("1-Employee System.");
			Console.WriteLine("2-Project System.");
			Console.WriteLine("3-Department System.");
			Console.WriteLine("4-Employees Projects.");
		    Console.WriteLine("5-Exit.");
		}
		public void Run()
		{
			

			byte choice = 0;
			
			while (choice != 5)
			{
				Console.Clear();

				do
				{
					MainMenu();

				} while (!byte.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 5));

				switch (choice)
				{

					case 1:
						{
							Console.Clear();
							int count = Employees.Count;
							Employees.Run();
							if(count < Employees.Count)
							{
								// the count or counter represents about last Employee ID
								var E = Employees.GetEmployeeByID(Employees.Count);
								Departments.AssignEmployee(E);
							}
							break;
						}
					case 2:
						{
							Console.Clear();
							int count = Projects.Count;
							Projects.Run();
							if (count < Projects.Count)
							{
								// the count or counter represents about last Employee ID
								var P = Projects.GetProjectByID(Employees.Count);
								Departments.AssignProject(P);
							}
							break;
						}
					case 3:
						{
							Console.Clear();
							Departments.Run();
							break;
						}
					case 4:
						{
							Console.Clear();
							int count = EmployeesProjects.Count;
							EmployeesProjects.Run();
							if (count < EmployeesProjects.Count)
							{
								// the count or counter represents about last Employee ID
								var W = EmployeesProjects.GetMappingByID(EmployeesProjects.Count);
								Employees.AssignProject(W);
								Projects.AssignEmployee(W);
							}

							break;
						}
					

				}



			}


		}

	}
}
