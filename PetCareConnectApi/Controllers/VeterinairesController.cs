using Microsoft.AspNetCore.Mvc;
using PetCareConnectApi.Models.Veterinaires;
using System;
using System.Collections.Generic;

namespace PetCareConnectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinairesController : ControllerBase
    {
        // Exemple de liste statique de vétérinaires (remplacez ceci par l'accès à votre base de données)
        private static List<VeterinairesModels> listeVeterinaires = new List<VeterinairesModels>
        {
            new VeterinairesModels { Veterinaire_id = 1, Pseudo_veterinaire = "Vet1", Prenom_veterinaire = "John", Nom_veterinaire = "Doe", Mail_veterinaire = "vet1@example.com", Mots_de_passe_veterinaire = "password123" },
            new VeterinairesModels { Veterinaire_id = 2, Pseudo_veterinaire = "Vet2", Prenom_veterinaire = "Jane", Nom_veterinaire = "Smith", Mail_veterinaire = "vet2@example.com", Mots_de_passe_veterinaire = "securepass" }
            // Ajoutez d'autres exemples de vétérinaires si nécessaire
        };

        // GET api/veterinaires
        [HttpGet]
        public ActionResult<IEnumerable<VeterinairesModels>> Get()
        {
            return Ok(listeVeterinaires);
        }

        // GET api/veterinaires/5
        [HttpGet("{id}")]
        public ActionResult<VeterinairesModels> Get(int id)
        {
            var veterinaire = listeVeterinaires.Find(v => v.Veterinaire_id == id);
            if (veterinaire == null)
            {
                return NotFound();
            }

            return Ok(veterinaire);
        }

        // POST api/veterinaires
        [HttpPost]
        public ActionResult Post([FromBody] VeterinairesModels veterinaire)
        {
            // Vous devriez généralement ajouter la logique pour enregistrer le vétérinaire dans la base de données ici
            veterinaire.Veterinaire_id = listeVeterinaires.Count + 1;
            listeVeterinaires.Add(veterinaire);

            return CreatedAtAction(nameof(Get), new { id = veterinaire.Veterinaire_id }, veterinaire);
        }

        // PUT api/veterinaires/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] VeterinairesModels updatedVeterinaire)
        {
            var existingVeterinaire = listeVeterinaires.Find(v => v.Veterinaire_id == id);
            if (existingVeterinaire == null)
            {
                return NotFound();
            }

            // Vous devriez généralement ajouter la logique pour mettre à jour le vétérinaire dans la base de données ici
            existingVeterinaire.Pseudo_veterinaire = updatedVeterinaire.Pseudo_veterinaire;
            existingVeterinaire.Prenom_veterinaire = updatedVeterinaire.Prenom_veterinaire;
            existingVeterinaire.Nom_veterinaire = updatedVeterinaire.Nom_veterinaire;
            existingVeterinaire.Mail_veterinaire = updatedVeterinaire.Mail_veterinaire;
            existingVeterinaire.Mots_de_passe_veterinaire = updatedVeterinaire.Mots_de_passe_veterinaire;

            return NoContent();
        }

        // DELETE api/veterinaires/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var veterinaireToRemove = listeVeterinaires.Find(v => v.Veterinaire_id == id);
            if (veterinaireToRemove == null)
            {
                return NotFound();
            }

            // Vous devriez généralement ajouter la logique pour supprimer le vétérinaire de la base de données ici
            listeVeterinaires.Remove(veterinaireToRemove);

            return NoContent();
        }
    }
}
