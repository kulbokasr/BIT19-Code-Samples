using StudentApplication.Data;
using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Repositories
{
    public class StudentRepository : RepositoryBase<Student>
    {
        public StudentRepository(DataContext context) : base(context)
        {

        }
    }
}
