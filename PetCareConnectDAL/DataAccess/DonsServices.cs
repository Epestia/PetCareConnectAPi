using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using PetCareConnectDAL.Entity;

namespace PetCareConnectDAL.Repository
{
    public class DonsService : IDonsRepository
    {
        private readonly DbConnection _connection;

        public DonsService(DbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<DonsEntity> GetAllDons()
        {
            _connection.Open();
            return _connection.Query<DonsEntity>("SELECT * FROM Dons");
        }

        public DonsEntity GetDonsById(int donsId)
        {
            _connection.Open();
            return _connection.QueryFirstOrDefault<DonsEntity>("SELECT * FROM Dons WHERE Dons_id = @Dons_id", new { Dons_id = donsId });
        }

        public void InsertDons(DonsEntity dons)
        {
            _connection.Open();
            _connection.Execute("INSERT INTO Dons (Montants, Date_dons, Option_payement, Statuts) VALUES (@Montants, @Date_dons, @Option_payement, @Statuts)", dons);
        }

        // Ajoutez d'autres méthodes selon vos besoins (Update, Delete, etc.)
    }
}
