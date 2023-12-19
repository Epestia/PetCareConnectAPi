using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnectDAL.Entity
{
    public class DonsEntity
    {
        public int Dons_id { get; set; }
        public Decimal Montants { get; set; }
        public DateTime Date_dons { get; set; }
        public string Option_payement { get; set; }
        public string Statuts { get; set; }

    }
}
