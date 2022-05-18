using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using Main;
using Microsoft.Data.SqlClient;

namespace Domein
{
    public class DomeinController
    {
        private Garage _garage;

        public List<Auto> _autos = new();

        public DomeinController(IAutoRepository autoRepo, IOnderhoudRepository onderhoudRepo)
        {
            _garage = new Garage(autoRepo, onderhoudRepo);
        }

        public List<string> GeefAutos()
        {
            return _garage.GeefAutos()
                .Select(Auto => Auto.ToString())
                .ToList();
        }

        public void RegistreerAuto(string nummerplaat, string merk, string model)
        {
            string query =
                $"INSERT INTO voertuig(V_Nummerplaat,V_Merk,V_Type) VALUES ('{nummerplaat}','{merk}','{model}');" + "SELECT CAST(scope_identity() AS int)"; ;
            using (SqlConnection connect = new SqlConnection(Services.Configurator.DbConnection))
            {
                SqlCommand cmd = new SqlCommand(query, connect);

                try
                {
                    connect.Open();
                    _autos.Add(new Auto(nummerplaat, merk, model, (Int32)cmd.ExecuteScalar()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string GeefAuto(string v)
        {
            throw new NotImplementedException();
        }

        public void WijzigAuto(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void VerwijderAuto(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}