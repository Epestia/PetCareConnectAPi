using PetCareConnectDAL.Entity;
using System.Collections.Generic;

namespace PetCareConnectDAL.Repository
{
    public interface IDonsRepository
    {
        IEnumerable<DonsEntity> GetAllDons();
        DonsEntity GetDonsById(int donsId);
        void InsertDons(DonsEntity dons);
        // Ajoutez d'autres méthodes selon vos besoins (Update, Delete, etc.)
    }
}
