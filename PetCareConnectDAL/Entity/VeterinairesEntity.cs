using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnectDAL.Entity
{
    public class VeterinairesEntity
    {
        public int Veterinaire_id { get; set; }
        public string Pseudo_veterinaire { get; set; }
        public string Prenom_veterinaire { get; set; }
        public string Nom_veterinaire { get; set; }
        public string Mail_veterinaire { get; set; }
        public string Mots_de_passe_veterinaire { get; set; }
    }
}
