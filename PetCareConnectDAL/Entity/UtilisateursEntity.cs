using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnectDAL.Entity
{
    public class UtilisateursEntity
    {
        public int Utilisateur_id { get; set; }
        public string Pseudo_utilisateur { get; set; }
        public string Prenom_utilisateur { get; set; }
        public string Nom_utilisateur { get; set; }
        public string Adresse_mail { get; set; }
        public string Mots_de_passe { get; set; }
    }
}
