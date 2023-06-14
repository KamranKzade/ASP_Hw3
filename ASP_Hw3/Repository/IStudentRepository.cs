using ASP_Hw3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Hw3.Repository
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetAllAsync();
        Task Add(Student student);
		Task Delete(int id);
		Task Update(int id);
		Task<Student> GetByIdAsync(int id);
	}
}
