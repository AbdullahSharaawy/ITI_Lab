using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCsharp
{
	public static class ReadMethods
	{
		public static int Readint(string Message)
		{
			int ID;
			do
			{
				Console.Write(Message);

			} while (!int.TryParse(Console.ReadLine(), out ID));
			return ID;
		}
		public static string ReadString(string Message)
		{
			string Name;
			do
			{
				Console.Write(Message);
				Name = Console.ReadLine();

			} while (string.IsNullOrEmpty(Name));
			return Name;
		}
		public static decimal ReadDecimal(string Message)
		{
			decimal Salary;
			do
			{
				Console.Write(Message);

			} while (!decimal.TryParse(Console.ReadLine(), out Salary));
			return Salary;
		}
		public static DateTime ReadDate(string Messsage)
		{
			DateTime DB;
			do
			{
				Console.Write(Messsage);

			} while (!DateTime.TryParse(Console.ReadLine(), out DB));
			return DB;
		}
	}
}
