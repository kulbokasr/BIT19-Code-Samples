﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApplication.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    public List<Todo> Todos { get; set; }   
    }
}
