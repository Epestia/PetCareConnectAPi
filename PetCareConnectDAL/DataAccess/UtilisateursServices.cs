using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using PetCareConnectDAL.Entity;

namespace PetCareConnectDAL.Repository
{
    public class UtilisateursService : IUtilisateursRepository
    {
        private readonly DbConnection _connection;

        public UtilisateursService(DbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<UtilisateursEntity> GetAllUtilisateurs()
        {
            _connection.Open();
            return _connection.Query<UtilisateursEntity>("SELECT * FROM Utilisateurs");
        }

        public UtilisateursEntity GetUtilisateurById(int utilisateurId)
        {
            _connection.Open();
            return _connection.QueryFirstOrDefault<UtilisateursEntity>("SELECT * FROM Utilisateurs WHERE Utilisateur_id = @Utilisateur_id", new { Utilisateur_id = utilisateurId });
        }

        public void InsertUtilisateur(UtilisateursEntity utilisateur)
        { 
            _connection.Open();
            _connection.Execute("INSERT INTO Utilisateurs (Pseudo_utilisateur, Prenom_utilisateur, Nom_utilisateur, Adresse_mail, Mots_de_passe) VALUES (@Pseudo_utilisateur, @Prenom_utilisateur, @Nom_utilisateur, @Adresse_mail, @Mots_de_passe)", utilisateur);
        }

        // Ajoutez d'autres méthodes selon vos besoins (Update, Delete, etc.)
    }
}
