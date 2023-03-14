
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentRestAPI.Models
{
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public class StudentRepository : IStudentRepository
	{
		private readonly AppDbContext appDbContext;
		public StudentRepository(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
		}

		public async Task<Student> AddStudent(Student student)
		{
			var result = await AppDbContext.Students.AddAsync(student);
			await appDbContext.SaveChangesAsync();
			return result.Entity;
		}

		public async Task DeleteStudent(int studentId)
		{
			var result = await appDbContext.Students
				.FirstOrDefaultAsync(e => e.StudentId == studentId);

			if (result != null)
			{
				appDbContext.Students.Remove(result);
				await appDbContext.SaveChangesAsync();

			}

		}

		public async Task<Student> GetStudent(int studentId) => await appDbContext.Students
				.FirstOrDefaultAsync(e => e.StudentId == studentId);

		public async Task<Student> GetStudentByEmail(string email)
		{
			return await appDbContext.Students
				.FirstOrDefaultAsync(e => e.Email == email);
		}

		public async Task<IEnumerable<Student>> GetStudents()
		{
			return await appDbContext.Students.ToListAsync();
		}

		public async Task<IEnumerable<Student>> Search (string name, Gender? gender)
		{
			IQueryable<Student> query = appDbContext.Students;
			if (!string.IsNullOrEmpty(name))
			{
				query = query.Where(e => e.FirstName.Contains(name)
							 || e.LastName.Contains(name));
			}


			if (gender != null)
			{
				query = query.Where(e => e.Gender == gender);
			}

			return await query.ToListAsync();
		}

		public async Task<Student> UpdateStudent(Student student)
		{
			var result = await appDbContext.Students
				.FirstOrDefaultAsync(e => e.StudentId == student.StudentId);

			if(result != null)
			{
				result.FirstName = student.FirstName;
				result.LastName = student.LastName;
				result.Email = student.Email;
				result.DateOfBirth = student.DateOfBirth;
				result.Gender = student.Gender;
				if(student.DepartmentId != 0)
				{
					result.DepartmentId = student.DepartmentId;
				}

				result.PhotoPath = student.PhotoPath;
				await appDbContext.SaveChangesAsync();
				return result;
			}

			return null;
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}
	
}
