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
    public class SchoolController : ControllerBase
    {
        private DataContext _dataContext;

        public SchoolController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public List<School> GetAll()
        {
            return _dataContext.Schools.ToList();
        }
        [HttpPost]
        public string Create(School school)
        {
            _dataContext.Schools.Add(school);
            _dataContext.SaveChanges();
            return "School created";
        }
        [HttpPut("{id}")]
        public string Update([FromRoute] int id, [FromBody] School schoolUpdate)
        {
            var school = _dataContext.Schools.Find(id);
            school.Name = schoolUpdate.Name;
            _dataContext.SaveChanges();
            return "School name updated";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _dataContext.Schools.Remove(_dataContext.Schools.Find(id));
            _dataContext.SaveChanges();
            return "School deleted";
        }
    }
}
