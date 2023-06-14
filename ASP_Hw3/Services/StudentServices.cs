using System.Linq;
using ASP_Hw3.Entities;
using ASP_Hw3.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP_Hw3.Services
{
	public class StudentServices : IStudentServices
	{
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> GetAllByKey(string key = "")
        {
            var data = await _studentRepository.GetAllAsync();

            return key != "" ? data.Where(s =>
            s.FirstName.ToLower().Contains(key.ToLower())).ToList()
            : data;
        }

        public async Task Add(Student student)
		{
			await _studentRepository.Add(student);
		}

		public async Task Delete(Student student)
		{
			await _studentRepository.Delete(student);
		}


		public async Task<Student> GetByIdAsync(int id)
		{
			return await _studentRepository.GetByIdAsync(id); ;
		}

		public async Task Update(Student student)
		{
			
			await _studentRepository.Update(student);
		}
	}
}
