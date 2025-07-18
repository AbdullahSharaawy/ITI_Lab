using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DaysCsharp.Day10
{
	public class Developer:Employee
	{
		public double _salary { get; set; }
		public double _bonus_percentage { get; set; }
		public Developer(int id, string name, string email, string phone, DateTime CreatedOn, double salary, double bonus_percentage, string Password) : base(id, name, email, phone, CreatedOn, Password)
		{
			_salary = salary;
			_bonus_percentage = bonus_percentage;
		}

		public override double CalculateBonus()
		{
			return this._salary * (this._bonus_percentage / 100); ;
		}

		public override double CalculateSalary()
		{
			return this._salary;
		}

		public override void DisplayInfo()
		{
			Console.WriteLine($"id: {this.ID} ,name: {this.Name} ,Email: {this.Email} ,Phone: {this.Phone}");
		}
	}
}
