using Domain;
using Domain.Contracts;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class AutoRepository : IAutoRepository
    {
        private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Pooling=False;TrustServerCertificate=true";

        // CRUD: Create, Read, Update, Delete - levenscyclus
        public List<Auto> Get()
        {
            List<Auto> autoLijst = new();
            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new("SELECT Nummerplaat, Model, Merk FROM Autos", connection);

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                string nummerplaat = (string)dataReader["nummerplaat"];
                                string merk = (string)dataReader["merk"];
                                string model = (string)dataReader["model"];

                                autoLijst.Add(new Auto(nummerplaat, merk, model));
                            }
                        }
                    }
                }
            }
            catch(System.Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw; // we werpen de uitzondering ongewijzigd verder op 
            }

            return autoLijst;
        }

        public Auto Read(string nummerplaat)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    // Slechtst:
                    SqlCommand slowCommand = new("SELECT Model, Merk FROM Autos Where Nummerplaat = '" + nummerplaat + "'", connection);
                    // Beter:
                    SqlCommand command = new($"SELECT Model, Merk FROM Autos Where Nummerplaat = '{nummerplaat}'", connection);
                    // Nog beter: string is "immutable"! COW = copy on write
                    StringBuilder sb = new("SELECT Model, Merk FROM Autos Where Nummerplaat = '");
                    sb.Append(nummerplaat);
                    sb.Append('\'');
                    SqlCommand fasterCommand = new(sb.ToString());
                    // Best: met parameters - maak je template query maar 1 keer!

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            string merk = (string)dataReader["merk"];
                            string model = (string)dataReader["model"];

                            return new Auto(nummerplaat, model, merk);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        //tag::executeNonReader[]
        public void Insert(Auto auto)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    // beter: met chassisnr of zelfs identity primary key - dan kan nummerplaat veranderen
                    // bij identity: ExecuteScalar() SELECT SCOPE_IDENTITY
                    string insertSql = $"INSERT INTO Autos (Nummerplaat, Merk, Model) VALUES ('{auto.Nummerplaat}', '{auto.Merk}', '{auto.Model}')";
                    SqlCommand insertCommand = new(insertSql, connection);
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public void Delete(string nummerplaat)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    string deleteSql = $"DELETE FROM Autos WHERE Nummerplaat = '{nummerplaat}';";
                    SqlCommand deleteCommand = new(deleteSql, connection);
                    deleteCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        public void Update(Auto auto)
        {
            try
            {
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    string updateSql = $"UPDATE Autos SET Model = '{auto.Model}', Merk = '{auto.Merk}' WHERE Nummerplaat = '{auto.Nummerplaat}'; ";
                    SqlCommand updateCommand = new(updateSql, connection);
                    updateCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
