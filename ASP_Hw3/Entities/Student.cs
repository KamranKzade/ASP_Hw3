using System;

namespace ASP_Hw3.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime Birthdate { get; set; }


		public int GetAge()
		{
			if (DateTime.Now.Month - Birthdate.Month >= 0)
				return DateTime.Now.Year - Birthdate.Year;
			else
				return DateTime.Now.Year - Birthdate.Year - 1;
		}
	}
}
