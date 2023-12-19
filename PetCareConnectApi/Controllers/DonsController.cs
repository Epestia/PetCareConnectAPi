using Microsoft.AspNetCore.Mvc;
using PetCareConnectApi.Models.Dons;
using System;
using System.Collections.Generic;

namespace PetCareConnectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonsController : ControllerBase
    {
        // Exemple de liste statique de dons (remplacez ceci par l'accès à votre base de données)
        private static List<DonsModels> listeDons = new List<DonsModels>
        {
            new DonsModels { Dons_id = 1, Montants = 50.0m, Date_dons = DateTime.Now, Option_payement = "Carte de crédit", Statuts = "En attente" },
            new DonsModels { Dons_id = 2, Montants = 30.0m, Date_dons = DateTime.Now.AddDays(-7), Option_payement = "PayPal", Statuts = "Accepté" }
            // Ajoutez d'autres exemples de dons si nécessaire
        };

        // GET api/dons
        [HttpGet]
        public ActionResult<IEnumerable<DonsModels>> Get()
        {
            return Ok(listeDons);
        }

        // GET api/dons/5
        [HttpGet("{id}")]
        public ActionResult<DonsModels> Get(int id)
        {
            var don = listeDons.Find(d => d.Dons_id == id);
            if (don == null)
            {
                return NotFound();
            }

            return Ok(don);
        }

        // POST api/dons
        [HttpPost]
        public ActionResult Post([FromBody] DonsModels don)
        {
            // Vous devriez généralement ajouter la logique pour enregistrer le don dans la base de données ici
            don.Dons_id = listeDons.Count + 1;
            listeDons.Add(don);

            return CreatedAtAction(nameof(Get), new { id = don.Dons_id }, don);
        }

        // PUT api/dons/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DonsModels updatedDon)
        {
            var existingDon = listeDons.Find(d => d.Dons_id == id);
            if (existingDon == null)
            {
                return NotFound();
            }

            // Vous devriez généralement ajouter la logique pour mettre à jour le don dans la base de données ici
            existingDon.Montants = updatedDon.Montants;
            existingDon.Date_dons = updatedDon.Date_dons;
            existingDon.Option_payement = updatedDon.Option_payement;
            existingDon.Statuts = updatedDon.Statuts;

            return NoContent();
        }

        // DELETE api/dons/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var donToRemove = listeDons.Find(d => d.Dons_id == id);
            if (donToRemove == null)
            {
                return NotFound();
            }

            // Vous devriez généralement ajouter la logique pour supprimer le don de la base de données ici
            listeDons.Remove(donToRemove);

            return NoContent();
        }
    }
}
