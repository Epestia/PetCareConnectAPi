using System.Collections.Generic;
using PetCareConnectDAL.Entity;

namespace PetCareConnectDAL.Repository
{
    public interface IArticlesRepository
    {
        IEnumerable<ArticlesEntity> GetAllArticles();
        ArticlesEntity GetArticleById(int articlesId);
        void InsertArticle(ArticlesEntity article);
        // Ajoutez d'autres méthodes selon vos besoins (Update, Delete, etc.)
    }
}
