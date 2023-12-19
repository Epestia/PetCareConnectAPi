using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetCareConnectApi.Models.Articles;
using PetCareConnectApi.Models.Forms;
using PetCareConnectDAL.Entity;
using PetCareConnectDAL.Repository;
using System;

namespace PetCareConnectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesRepository _articlesRepository;

        public ArticlesController(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           

            return Ok(new List<string>() { "1", "2", "3" });
        }

        [HttpGet("/GetByID/{id}")]
        public ActionResult<ArticlesModels> GetArticleByid(int id)
        {
          

            var article = new ArticlesModels
            {
                Articles_Id = id,
                Titre = "Exemple de titre",
                Contenue = "Ceci est un exemple de contenu.",
                Date_publication = DateTime.UtcNow
            };

            return Ok(article);
        }

        [HttpGet("/GeTbyTitle/{titre}")]
        public ActionResult<ArticlesModels> GetArticleByTitre(string titre)
        {
       

            var article = new ArticlesModels
            {
                Articles_Id = 1,
                Titre = titre,
                Contenue = "Contenu de l'article par titre",
                Date_publication = DateTime.UtcNow
            };

            return Ok(article);
        }

        [HttpPost]
        public ActionResult<ArticlesModels> CreateArticle([FromBody] CreateArticleForm articleModel)
        {
     

            if (articleModel == null)
            {
                return BadRequest("L'objet article est nul.");
            }

            var newArticle = new ArticlesEntity
            {
                Titre = articleModel.Titre,
                Contenue = articleModel.Contenue,
                Date_publication = DateTime.UtcNow
         
            };

            
            _articlesRepository.InsertArticle(newArticle);

       
            return CreatedAtAction(nameof(GetArticleByid), new { id = newArticle.Articles_Id }, articleModel);
        }
    }
}
