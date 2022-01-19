using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public List<School> GetAll()
        {
            //return _schoolRepository.GetAll();
            return _dataContext.Schools.Include(i => i.Students).ToList();
        }
        [HttpGet("{id}")]
        public School GetById(int id)
        {
            return _schoolRepository.GetById(id);
        }
        [HttpPost]
        public string Create(School school)
        {
            _schoolRepository.Create(school);
            return "School created";
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
