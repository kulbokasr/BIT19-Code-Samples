using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Zoo.Models;

namespace Zoo.Services
{
    public class SponsorsService
    {
        private List<SponsorModel> sponsors = new List<SponsorModel>();
        private SqlConnection _connection;
        private readonly ZooService _zooService;
        public SponsorsService(ZooService zooService, SqlConnection sqlConnection)
        {
            _connection = sqlConnection;
            _zooService = zooService;
        }
        public List<ZooModel> animals()
        {
            return _zooService.ReadFromDB(); // ka padariau: tavo sponsor service db pasiekia zoo service. juo pasinaudoja, kad gautu animal list.
        }
        public List<SponsorModel> ReadFromDB()

        {
            _connection.Open();

            SqlCommand command = new SqlCommand("Select dSponsors.*, Zoo.Name from Sponsors JOIN Zoo ON Sponsors.ZooId = Zoo.Id", _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                SponsorModel sponsor = new SponsorModel();
                sponsor.Id = reader.GetInt32(0);
                sponsor.FirstName = reader.GetString(1);
                sponsor.LastName = reader.GetString(2);
                sponsor.Amount = reader.GetInt32(3);
                sponsor.ZooId = reader.GetInt32(4);
                sponsor.Animal.Name = reader.GetString(5);

                sponsors.Add(sponsor);
            }

            _connection.Close();

            return sponsors;
        }

        public void AddToDB(SponsorModel model)
        {
            _connection.Open();
            string sql = "insert into dbo.Sponsors (FirstName, LastName, Amount, ZooId) values(@first, @second, @third, @last)";
            SqlCommand command = new SqlCommand(sql, _connection);
            command.Parameters.Add("@first", SqlDbType.NVarChar).Value = model.FirstName;
            command.Parameters.Add("@second", SqlDbType.NVarChar).Value = model.LastName;
            command.Parameters.Add("@third", SqlDbType.Int).Value = model.Amount;
            command.Parameters.Add("@last", SqlDbType.NVarChar).Value = model.ZooId;

            int rowsAdded = command.ExecuteNonQuery();

            _connection.Close();
        }

    }
}
