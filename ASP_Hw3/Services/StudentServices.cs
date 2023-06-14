using System.Linq;
using ASP_Hw3.Entities;
using ASP_Hw3.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP_Hw3.Services
{
	public class StudentServices : IStudentServices
	{
		public readonly IStudentRepository _studentRepo;

		public StudentServices(IStudentRepository studentRepo)
		{
			_studentRepo = studentRepo;
		}

		public async Task Add(Student student)
		{
			await _studentRepo.Add(student);
		}

		public async Task Delete(Student student)
		{
			await _studentRepo.Delete(student);
		}

		public async Task<List<Student>> GetAllKey(string key = "")
		{
			var data = await _studentRepo.GellAllAsync();

			return key != "" ? data.Where(s =>
			s.FirstName.ToLower().Contains(key.ToLower())).ToList() : data;
		}

		public async Task<Student> GetByIdAsync(int id)
		{
			return await _studentRepo.GetByIdAsync(id); ;
		}

		public async Task Update(Student student)
		{
			await _studentRepo.Update(student);
		}
	}
}
