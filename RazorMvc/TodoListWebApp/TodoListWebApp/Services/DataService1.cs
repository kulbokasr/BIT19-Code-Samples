using System.Collections.Generic;
using TodoListWebApp.Models;

namespace TodoListWebApp.Services
{
    public class DataService1
    {
        private List<TaskModelLine> tasks = new List<TaskModelLine>()
        {
            new TaskModelLine() {NameAndDescription = "Grindu plovimas - isplauti grindis"},
            new TaskModelLine() {NameAndDescription = "Langu plovimas - isplauti langus"}
        };
        public List<TaskModelLine> GetAll()
        {
            return tasks;
        }

        public void Add(TaskModelLine tasksModel)
        {
            tasks.Add(tasksModel);
        }
    }
}
