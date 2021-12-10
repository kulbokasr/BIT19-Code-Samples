using System;
using System.Collections.Generic;
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

        public List<ZooModel> ReadFromDB()//cia grazini lisat

        {// tai tau reikia susikurti db objekta iri inicializuoti.
            _connection.Close();
            _connection.Open(); // BOOM. atidarėm connection. 

            SqlCommand command = new SqlCommand("Select * from Zoo", _connection);// /* cia antras parametras yra DB objektas, kuris zino KAIP prisijungti prie duombazes*/
            
            SqlDataReader reader = command.ExecuteReader();      

            while (reader.Read())
            {  
                ZooModel animal = new ZooModel();
                animal.Name = reader[0].ToString();
                animal.Description = reader[1].ToString();
                animal.Age = Convert.ToInt32(reader[2].ToString()); // KLAUSIMAS kodel man cia neina ToInt32 iskart naudoti?
                animal.Gender = reader[3].ToString();

                animals.Add(animal);
            }
            _connection.Close();// BOOM. uzda
            return animals;
        }

    }
}
