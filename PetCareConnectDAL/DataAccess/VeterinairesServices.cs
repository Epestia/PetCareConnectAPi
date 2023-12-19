using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using PetCareConnectDAL.Entity;

namespace PetCareConnectDAL.Repository
{
    public class VeterinairesService : IVeterinairesRepository
    {
        private readonly DbConnection _connection;

        public VeterinairesService(DbConnection _connection)
        {
            _connection = _connection;
        }

        public IEnumerable<VeterinairesEntity> GetAllVeterinaires()
        {
            _connection.Open();
            return _connection.Query<VeterinairesEntity>("SELECT * FROM Veterinaires");
        }

        public VeterinairesEntity GetVeterinaireById(int veterinaireId)
        {
            _connection.Open();
            return _connection.QueryFirstOrDefault<VeterinairesEntity>("SELECT * FROM Veterinaires WHERE Veterinaire_id = @Veterinaire_id", new { Veterinaire_id = veterinaireId });
        }

        public void InsertVeterinaire(VeterinairesEntity veterinaire)
        {
            _connection.Open();
            _connection.Execute("INSERT INTO Veterinaires (Pseudo_veterinaire, Prenom_veterinaire, Nom_veterinaire, Mail_veterinaire, Mots_de_passe_veterinaire) VALUES (@Pseudo_veterinaire, @Prenom_veterinaire, @Nom_veterinaire, @Mail_veterinaire, @Mots_de_passe_veterinaire)", veterinaire);
        }
    }
}

// Ajoutez d'autres méthodes selon vos besoins (
