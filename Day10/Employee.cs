using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp.Day10
{
	public abstract class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime DeletedOn { get;  set; }
		public abstract double CalculateSalary();
		public abstract double CalculateBonus();
		public abstract void DisplayInfo();
		protected Employee(int id, string name, string email, string phone, DateTime CreatedOn, string password)
		{
			ID = id;
			Name = name;
			Email = email;
			Phone = phone;
			Password = password;
		}


	}
}
