using ASP_Hw3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_Hw3.Models
{
	public class StudentDbContext : DbContext
	{
		public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

		public DbSet<Student> Students { get; set; }
	}
}
