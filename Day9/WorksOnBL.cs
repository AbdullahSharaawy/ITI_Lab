using Day8;
using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day9
{
	public class WorksOnBL
	{
		private WorksOn[] mapping;
		public WorksOnBL(int length)
		{
			mapping = new WorksOn[length];
		}
		public int Count
		{
			get => WorksOn.WCounter;
		}
		private WorksOn CreateMapping()
		{
			int EID = ReadMethods.Readint("Please Enter Employee ID: ");
			while (EID > Employee.ECounter)
			{
				Console.WriteLine();
				EID = ReadMethods.Readint("Please Enter a valid Employee ID: ");
			}
			int PID = ReadMethods.Readint("Please Enter Project ID: ");
			while (PID > Project.PCounter)
			{
				Console.WriteLine();
				PID = ReadMethods.Readint("Please Enter a valid Project ID: ");
			}
			return new WorksOn(PID, EID);
		}
		private void DisplayMapping(WorksOn Mapping)
		{
			Console.WriteLine($"ID: {Mapping.ID}");
			Console.WriteLine($"Project ID: {Mapping.ProjectID}");
			Console.WriteLine($"Employee ID: {Mapping.EmployeeID}");
			
		}
		
		//private void DeleteProject(ref Project Project)
		//{
		//	if (Project == null) return;
		//	Project = null; // Set to null to delete the reference
		//	Console.WriteLine("Project deleted successfully.");
		//}
		public WorksOn GetMappingByID(int id)
		{
			for (int i = 0; i < WorksOn.WCounter; i++)
			{
				if (mapping[i].ID == id)
				{
					return mapping[i];
				}
			}
			return null;
		}
		private void PrintMainMenu()
		{
			Console.WriteLine("");
			Console.WriteLine("1-Assign Employee to Project");
			Console.WriteLine("2-Get All Assigns");
			Console.WriteLine("3-Show Assign By ID");
			Console.WriteLine("4-Exist");
		}
		private void GetAllAssigns()
		{

			Console.WriteLine("list of Assigns: ");
			Console.WriteLine();
			for (int i = 0; i < WorksOn.WCounter; i++)
			{
				DisplayMapping(mapping[i]);
			}
			Console.WriteLine();
		}
		public void Run()
		{
			Console.Clear();

			byte choice = 0;
			int ID;
			while (choice != 4)
			{


				do
				{
					PrintMainMenu();

				} while (!byte.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 4));

				switch (choice)
				{

					case 1:
						{
							Console.Clear();
							mapping[WorksOn.WCounter++] = CreateMapping();
							break;
						}
					case 2:
						{
							Console.Clear();
							GetAllAssigns();
							break;
						}
					case 3:
						{
							Console.Clear();
							ID = ReadMethods.Readint("Enter The Assign ID: ");
							var M = GetMappingByID(ID);
							DisplayMapping(M);
							break;
						}
					
				}



			}


		}
	}
}
