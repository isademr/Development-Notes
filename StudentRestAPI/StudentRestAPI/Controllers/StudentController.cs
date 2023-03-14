using Microsoft.AspNetCore.Mvc;
using StudentRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestAPI.Controllers
{
	[Route ("api/[Controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IStudentRepository studentRepository;

		public StudentsController(IStudentRepository studentRepository)
		{
			this.studentRepository = studentRepository;
		}

		[HttpGet("{Search}")]
		public async Task<ActionResult<IEnumerable<Student>>> Search(string name, Gender? gender)
		{

		}
	}
}
