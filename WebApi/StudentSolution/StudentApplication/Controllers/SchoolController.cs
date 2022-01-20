using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApplication.Data;
using StudentApplication.Dtos;
using StudentApplication.Models;
using StudentApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private SchoolRepository _schoolRepository;
        private DataContext _dataContext;

        public SchoolController(SchoolRepository schoolRepository, DataContext dataContext)
        {
            _schoolRepository = schoolRepository;
            _dataContext = dataContext;
        }

        [HttpGet]
        public List<FakeSchool> GetAll()
        {
            var schools = _dataContext.Schools.ToList();
            
            List<FakeSchool> fakeSchools = new List<FakeSchool>();
            foreach (var school in schools)
            {
                FakeSchool fakeSchool = new FakeSchool()
                { 
                    Students = new List<FakeStudent>()
                };
                fakeSchool.Name = school.Name;
                fakeSchool.Id = school.Id;
                fakeSchool.Created = school.Created;
                
                List<FakeStudent> fakeStudents = new List<FakeStudent>();
                var students = _dataContext.Students.Where(i => i.SchoolId == school.Id).ToList();
                foreach (var student in students)
                {
                    FakeStudent fakeStudent = new FakeStudent();
                    fakeStudent.SchoolId = student.SchoolId;
                    fakeStudent.Name = student.Name;
                    fakeStudent.Sex = "fix this if you want";
                    fakeStudent.Id = student.Id;
                    fakeSchool.Students.Add(fakeStudent);
                }
                fakeSchools.Add(fakeSchool);
            }
            //var schoolStudent = new SchoolStudent()
            //{
            //    Schools = _dataContext.Schools.Include(i => i.Students).ToList()
            //};
            //return _schoolRepository.GetAll();
            return fakeSchools;
        }
        [HttpGet("{id}")]
        public School GetById(int id)
        {
            return _schoolRepository.GetById(id);
        }
        [HttpPost]
        public IActionResult Create(School school)
        {
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                _schoolRepository.Create(school);
                return new ObjectResult("School created") { StatusCode = StatusCodes.Status201Created };  
            }
            else
            {
                return new ObjectResult("Wrong input") { StatusCode = StatusCodes.Status422UnprocessableEntity };
            }
        }


        [HttpPut("{id}")]
        public string Update([FromRoute] int id, [FromBody] School schoolUpdate)
        {
            var school = _schoolRepository.GetById(id); ;
            school.Name = schoolUpdate.Name;
            _schoolRepository.Update(school);
            return "School name updated";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _schoolRepository.Delete(id);
            return "School deleted";
        }
    }
}
