using ASP_Hw3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Hw3.Repository
{
	public interface IStudentRepository
	{
		Task<List<Student>> GellAllAsync();
		Task Add(Student student);
		Task Delete(Student student);
		Task Update(Student student);
		Task<Student> GetByIdAsync(int id);
	}
}
