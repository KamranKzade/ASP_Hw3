using ASP_Hw3.Entities;
using ASP_Hw3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Hw3.Repository
{
	public class StudentRepository : IStudentRepository
	{
		public readonly StudentDbContext _dbContext;

		public async Task Add(Student student)
		{
			await _dbContext.Students.AddAsync(student);
			await _dbContext.SaveChangesAsync();
		}

		public async Task Delete(Student student)
		{
			_dbContext.Entry(student).State = EntityState.Detached;
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<Student>> GellAllAsync()
		{
			return await _dbContext.Students.ToListAsync();
		}

		public async Task<Student> GetByIdAsync(int id)
		{
			return await _dbContext.Students
				.FirstOrDefaultAsync(c => c.Id == id); ;
		}

		public async Task Update(Student student)
		{
			_dbContext.Entry(student).State |= EntityState.Modified;
			await _dbContext.SaveChangesAsync();
		}
	}
}
