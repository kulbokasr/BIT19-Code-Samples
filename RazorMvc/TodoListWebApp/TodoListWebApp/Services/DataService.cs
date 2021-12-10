using System;
using System.Collections.Generic;
using System.IO;
using TodoListWebApp.Models;

namespace TodoListWebApp.Services
{
    public class DataService
    {//o servisas atlieka juoda darba, paima duomenis is kazkur
        // pabandyk ziuredamas i sita struktura pritaikyti naujame projekte. 
        private List<TasksModel> tasks = new List<TasksModel>()
        {
            new TasksModel() {Name = "Langu plovimas", Description = "Isplauti langus"},
            new TasksModel() {Name = "Grindu plovimas", Description = "Isplauti grindis"}
        };
 
        public List<TasksModel> GetAll()//sitas metodas skaitytu viska is failo.
        {
            string[] data = File.ReadAllLines("data.txt");
            List<TasksModel> TasksList = new List<TasksModel>();
            Array.ForEach(data, row =>
            {
                string[] entries = row.Split("*");
                TasksList.Add  (new TasksModel() { Name = entries[0], Description = entries[1] });
            });


            return TasksList;
            // o cia perskaitai faila, susikonstruoji masyva objektu ir ji grazini. tiesiog pakoreguoji metodus biski
        }

        public void Add(TasksModel tasksModel)// sitas irasytu i faila
        {
           // tasks.Add(tasksModel); //vietoje sitos eilutes, kur adini i masyva, adink i faila. t.y write to file
            File.AppendAllText("./data.txt", $"{tasksModel.Name} - {tasksModel.Description} \r\n");
        }
    }
}

/*
 * 
Use File.ReadAllText and File.WriteAllText.

MSDN example excerpt:

// Create a file to write to.
string createText = "Hello and Welcome" + Environment.NewLine;
File.WriteAllText(path, createText); //write raso. stringas kuris yra kelias. pvz "./file.xtx" ir turinys ka irasai, irgi stringas.

...

// Open the file to read from.
string readText = File.ReadAllText(path);// o sitas skaito. 
//aiskiau ar..? 
//na kaip ir aisku kas ka daro, bet kaip sita pritaikyti reikia Task listui
 * */
