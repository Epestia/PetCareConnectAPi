using Microsoft.AspNetCore.Mvc;
using PetCareConnectApi.Models.Utilisateurs;

namespace PetCareConnectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Liste des utilisateurs";
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Utilisateur avec l'ID {id}";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] UtilisateursModels utilisateur)
        {

            return $"Utilisateur ajouté : {utilisateur.Pseudo_utilisateur}";
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] UtilisateursModels utilisateur)
        {
            return $"Utilisateur mis à jour avec l'ID {id}";
        }


        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {

            return $"Utilisateur supprimé avec l'ID {id}";
        }
    }
}
