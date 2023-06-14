﻿using ASP_Hw3.Entities;
using ASP_Hw3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_Hw3.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public readonly StudentDbContext _dbContext;

        public StudentRepository(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var data = _dbContext.Students.FirstOrDefaultAsync(c => c.Id == id);
            _dbContext.Entry(data).State = EntityState.Detached;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _dbContext.Students
                .FirstOrDefaultAsync(c => c.Id == id); ;
        }

        public async Task Update(int id)
        {
            var data = _dbContext.Students.FirstOrDefaultAsync(c => c.Id == id);
            _dbContext.Entry(data).State |= EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
