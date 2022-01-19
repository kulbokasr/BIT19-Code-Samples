using Microsoft.AspNetCore.Mvc;
using StudentApplication.Data;
using StudentApplication.Models;
using StudentApplication.Repositories;
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
        private StudentRepository _studentRepository;
        public StudentController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
        [HttpPost]
        public string Create(Student student)
        {
            _studentRepository.Create(student);
            return "Student created";
        }
        [HttpPut("{id}")]
        public string Update([FromRoute] int id, [FromBody] Student studentUpdate)
        {
            var student = _studentRepository.GetById(id);
            student.Name = studentUpdate.Name;
            student.Sex = studentUpdate.Sex;
            student.SchoolId = studentUpdate.SchoolId; 
            _studentRepository.Update(student);
            return "Student name, sex and school id updated";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _studentRepository.Delete(id);
            return "Student deleted";
        }
    }
}
