using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TodoListApplication.Data;
using TodoListApplication.Models;

namespace TodoListApplication.Controllers
{
    public class TodoController : Controller
    {
        private DataContext _context;

        public TodoController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Todo> todos = 
                _context.Categories.Include(c => c.Todos) //this is requiers to load child objects
                .Where(c => c.Name == "Category1")
                .SelectMany(c => c.Todos)
                .ToList();
           // List<Todo> todos = _context.Todos.Where(t => t.Description != null).ToList();
            return View(todos);
        }
    }
}