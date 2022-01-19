using Microsoft.AspNetCore.Mvc;
using StudentApplication.Data;
using StudentApplication.Dtos;
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
            SchoolStudent schoolStudent = new SchoolStudent()
            {
                Students = _studentRepository.GetAll()
            };
             
            return schoolStudent.Students;
        }
        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            SchoolStudent schoolStudent = new SchoolStudent()
            {
                Student = _studentRepository.GetById(id)
            };

            return schoolStudent.Student;
        }
        [HttpPost]
        public string Create(Student student)
        {
            SchoolStudent schoolStudent = new SchoolStudent()
            {
                Student = student
            };
            _studentRepository.Create(schoolStudent.Student);
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
