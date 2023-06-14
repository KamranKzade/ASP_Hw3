using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Hw3.Entities
{
	public class Student
	{
		public int Id { get; set; }

		[DisplayName("Name")][Required]
		public string FirstName { get; set; }
        
		[DisplayName("Surname")][Required]
        public string LastName { get; set; }
        
		[DisplayName("Mail")][Required]
        public string Email { get; set; }
        
		[DisplayName("BirthDay")]
        [Required]
        public DateTime Birthdate { get; set; }
	}
}
