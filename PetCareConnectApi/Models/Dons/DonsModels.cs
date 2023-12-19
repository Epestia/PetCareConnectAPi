namespace PetCareConnectApi.Models.Dons
{
    public class DonsModels
    {
        public int Dons_id { get; set; }
        public Decimal Montants { get; set; }
        public DateTime Date_dons{ get; set; }
        public string Option_payement { get; set; }
        public string Statuts { get; set; }

    }
}
