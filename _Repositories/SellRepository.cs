using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class SellRepository : BaseRepository, ISellModelRepository
    {
        public SellRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(SellModel sellModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Sell VALUES (@Sell_Customer_id, @Sell_Total, @Sell_Pay_Mode, @Sell_Observation)";
                command.Parameters.Add("@Sell_Customer_id", SqlDbType.NVarChar).Value = sellModel.CustomerId;
                command.Parameters.Add("@Sell_Total", SqlDbType.NVarChar).Value = sellModel.Total;
                command.Parameters.Add("@Sell_Pay_Mode", SqlDbType.NVarChar).Value = sellModel.PayMode;
                command.Parameters.Add("@Sell_Observation", SqlDbType.NVarChar).Value = sellModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Sell WHERE Sell_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(SellModel sellModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Sell 
                                      SET Sell_Customer_id=@Sell_Customer_id,
                                      Sell_Total=@sell_total,
                                      Sell_Pay_Mode=@sell_pay_mode,
                                      Sell_Observation=@Sell_observation
                                      WHERE Sell_Id = @id";
                command.Parameters.Add("@Sell_Customer_id", SqlDbType.NVarChar).Value = sellModel.CustomerId;
                command.Parameters.Add("@Sell_Total", SqlDbType.NVarChar).Value = sellModel.Total;
                command.Parameters.Add("@Sell_Pay_Mode", SqlDbType.NVarChar).Value = sellModel.PayMode;
                command.Parameters.Add("@Sell_Observation", SqlDbType.NVarChar).Value = sellModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = sellModel.Id;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<SellModel> GetAll()
        {
            var sellList = new List<SellModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Sell ORDER BY Sell_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sellModel = new SellModel();
                        sellModel.Id = (int)reader["Sell_Id"];
                        sellModel.CustomerId = (int)reader["Sell_Customer_id"];
                        sellModel.Total = (int)reader["Sell_Total"];
                        sellModel.PayMode = reader["Sell_Pay_Mode"].ToString();
                        sellModel.Observation = reader["Sell_Observation"].ToString();
                        sellList.Add(sellModel);
                    }
                }
            }
            return sellList;
        }

        public IEnumerable<SellModel> GetByValue(string value)
        {
            var sellList = new List<SellModel>();
            int sellId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string sellObservation = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Sell
                                        WHERE Sell_Id=@id or Sell_Observation LIKE @observation+ '%'
                                        ORDER By Sell_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = sellId;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = sellObservation;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sellModel = new SellModel();
                        sellModel.Id = (int)reader["Sell_Id"];
                        sellModel.CustomerId = (int)reader["Sell_Customer_id"];
                        sellModel.Total = (int)reader["Sell_Total"];
                        sellModel.PayMode = reader["Sell_Pay_Mode"].ToString();
                        sellModel.Observation = reader["Sell_Observation"].ToString();
                        sellList.Add(sellModel);

                    }
                }

            }
            return sellList;
        }

    }
}