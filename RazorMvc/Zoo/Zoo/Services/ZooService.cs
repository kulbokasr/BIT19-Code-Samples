﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Zoo.Models;

namespace Zoo.Services
{
    public class ZooService
    {
        private List<ZooModel> animals = new List<ZooModel>();
        //sukurk sql objekta ir padaryk konstrukroriu kuris ji inicializuotu. kaip kontroleryje darei su servisu praita paskaita
        private SqlConnection _connection; //sita konstruktoriuje inicializuok kaip.. servisą kontroleryje.

        public ZooService(SqlConnection sqlConnection) //konstrukroriu kuris ji inicializuotu. kaip kontroleryje darei su servisu praita paskaita
        {
            _connection = sqlConnection;
        }

        public List<ZooModel> ReadFromDB()//cia grazini lista

        {// tai tau reikia susikurti db objekta iri inicializuoti.
            _connection.Close();
            _connection.Open();  

            SqlCommand command = new SqlCommand("Select * from Zoo", _connection);// /* cia antras parametras yra DB objektas, kuris zino KAIP prisijungti prie duombazes*/
            
            SqlDataReader reader = command.ExecuteReader();      

            while (reader.Read())
            {  
                ZooModel animal = new ZooModel();
                animal.Id = reader.GetInt32(0);
                animal.Name = reader.GetString(1);
                animal.Description = reader.GetString(2);
                animal.Age = reader.GetInt32(3); 
                animal.Gender = reader.GetString(4);
        
                animals.Add(animal);
            }

            _connection.Close();

            return animals;
        }

        public void AddToDB(ZooModel model)
        {
            _connection.Close();
            _connection.Open();
            string sql = "insert into dbo.Zoo (Id, Name, Description, Age, Gender) values(@Zero, @first, @second, @third, @last)";
            SqlCommand command = new SqlCommand(sql, _connection);
            var mooodel = new ZooModel();
            command.Parameters.Add("@Zero", SqlDbType.Int).Value = model.Id;
            command.Parameters.Add("@first", SqlDbType.NVarChar).Value = model.Name;
            command.Parameters.Add("@second", SqlDbType.NVarChar).Value = model.Description;
            command.Parameters.Add("@third", SqlDbType.Int).Value = model.Age;
            command.Parameters.Add("@last", SqlDbType.NVarChar).Value = model.Gender;

            int rowsAdded = command.ExecuteNonQuery();

            _connection.Close();
        }
        
    }
}
