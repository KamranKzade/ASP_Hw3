using ASP_Hw3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Hw3.Services
{
	public interface IStudentServices
	{
		Task<List<Student>> GetAllByKey(string key = "");
		Task Add(Student student);
		Task Delete(Student student);
		Task Update(Student student);
		Task<Student> GetByIdAsync(int id);
	}
}
