using Day8;
using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day9
{
	public  class ProjectBL
	{
		private  Project[] projects;
        public ProjectBL(int length)
		{
			projects = new Project[length];
		}
		public int Count
		{
			get=>Project.PCounter;
		}
		 private Project CreateProject()
        {
            string name = ReadMethods.ReadString("Please Enter Project Name: ");
            string description = ReadMethods.ReadString("Please Enter Project Description: ");
            int? DeptID = ReadMethods.Readint("Please Enter Department ID: ");
			while (DeptID > Department.DCounter)
			{
				Console.WriteLine();
				DeptID = ReadMethods.Readint("Please Enter a valid Department ID: ");
			}
			return new Project(name, description, DateTime.Now,DeptID);
        }
         private void DisplayProject(Project project)
        {
            Console.WriteLine($"ID: {project.Id}");
            Console.WriteLine($"Name: {project.Name}");
            Console.WriteLine($"Description: {project.Description}");
            Console.WriteLine($"Start Date: {project.StartDate}");
			Console.WriteLine($"Department ID: {project.DeptID}");
			Console.WriteLine("Employees:");
            Console.WriteLine("this project is assigned to these employees: ");
			foreach (var item in project.WorksOn)
			{
               Console.WriteLine($"-Employee ID: {item.EmployeeID} ");
			}
		}
         private void UpdateProject(ref Project project)
        {

            if (project == null) return;
            byte choice = 0;
            while (choice != 4)
            {

                do
                {
                    Console.Write("1-Name , 2-Description , 3-DepartMent ID , 4-Back: ");

                } while (!byte.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4));

                switch (choice)
                {

                    case 1:
                        {
                            string Name = ReadMethods.ReadString("Please Enter Employee Name: "); ;
                            project.Name = Name;
                            break;
                        }
                    case 2:
                        {
                            string Description = ReadMethods.ReadString("Please Enter Project Description: ");
                            project.Description = Description;
                            break;
                        }
                    case 3:
                        {
                            int DeptID = ReadMethods.Readint("Please Enter Department ID: ");
                            project.DeptID = DeptID;
                            break;
                        }

                }

            }
        }
         private void DeleteProject(ref Project Project)
        {
            if (Project == null) return;
            Project = null; // Set to null to delete the reference
            Console.WriteLine("Project deleted successfully.");
        }
        public Project GetProjectByID( int id)
        {
            for (int i = 0; i < Project.PCounter; i++)
            {
                if (projects[i].Id == id)
                {
                    return projects[i];
                }
            }
            return null;
        }
		public void AssignEmployee(WorksOn W)
		{
			for (int i = 0; i < projects.Count(); i++)
			{
				if (W.ProjectID == projects[i].Id)
				{
					projects[i].WorksOn.Add(W); // Add employee to the department's employee list
					return; // Exit after assigning the employee
				}
			}
		}
		private void PrintMainMenu()
		{
			Console.WriteLine("");
			Console.WriteLine("1-Add Project");
			Console.WriteLine("2-Get All Projects");
			Console.WriteLine("3-Show Project By ID");
			Console.WriteLine("4-Update Project");
			Console.WriteLine("5-Exist");
		}
		private  void GetAllProjects()
		{

			Console.WriteLine("list of Projects: ");
			Console.WriteLine();
			for (int i = 0; i < Project.PCounter; i++)
			{
				DisplayProject(projects[i]);
			}
			Console.WriteLine();
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
							projects[Project.PCounter++]=CreateProject();
							break;
						}
					case 2:
						{
							Console.Clear();
							GetAllProjects();
							break;
						}
					case 3:
						{
							Console.Clear();
							ID = ReadMethods.Readint("Enter The Project ID: ");
							var p=GetProjectByID(ID);
							DisplayProject(p);
							break;
						}
					case 4:
						{
							Console.Clear();
							ID = ReadMethods.Readint("Enter The Project ID: ");
							var p = GetProjectByID(ID);
							if (p != null)
								UpdateProject(ref p);
							else
								Console.WriteLine("Project not found.");
							break;
						}

				}



			}


		}
	}
}
