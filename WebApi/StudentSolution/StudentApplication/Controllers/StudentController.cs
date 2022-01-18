using Microsoft.AspNetCore.Mvc;
using StudentApplication.Data;
using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private DataContext _dataContext;

        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _dataContext.Students.ToList();
        }
        [HttpPost]
        public string Create(Student student)
        {
            _dataContext.Students.Add(student);
            _dataContext.SaveChanges();
            return "Student created";
        }
        [HttpPut("{id}")]
        public string Update([FromRoute] int id, [FromBody] Student studentUpdate)
        {
            var student = _dataContext.Students.Find(id);
            student.Name = studentUpdate.Name;
            student.Sex = studentUpdate.Sex;
            student.SchoolId = studentUpdate.SchoolId; 
            _dataContext.SaveChanges();
            return "Student name updated";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _dataContext.Students.Remove(_dataContext.Students.Find(id));
            _dataContext.SaveChanges();
            return "Student deleted";
        }
    }
}
{

    }
}
