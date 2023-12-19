using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnectDAL.Entity
{
    public class ArticlesEntity
    {
        public int Articles_Id { get; set; }
        public string Titre { get; set; }
        public string Contenue { get; set; }
        public DateTime Date_publication { get; set; }
    }
}
