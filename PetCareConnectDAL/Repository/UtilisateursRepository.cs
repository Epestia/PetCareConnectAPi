using PetCareConnectDAL.Entity;
using System.Collections.Generic;

namespace PetCareConnectDAL.Repository
{
    public interface IUtilisateursRepository
    {
        IEnumerable<UtilisateursEntity> GetAllUtilisateurs();
        UtilisateursEntity GetUtilisateurById(int utilisateurId);
        void InsertUtilisateur(UtilisateursEntity utilisateur);
        // Ajoutez d'autres méthodes selon vos besoins (Update, Delete, etc.)
    }
}
