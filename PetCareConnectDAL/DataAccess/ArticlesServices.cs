using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using PetCareConnectDAL.Entity;
using PetCareConnectDAL.Repository;

namespace PetCareConnectDAL.DataAccess
{
    public class ArticlesServices : IArticlesRepository
    {
        private readonly DbConnection _connection;

        public ArticlesServices(DbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<ArticlesEntity> GetAllArticles()
        {
            _connection.Open();
            return _connection.Query<ArticlesEntity>("SELECT * FROM Articles");
            
        }

        public ArticlesEntity GetArticleById(int articlesId)
        {

                _connection.Open();
                return _connection.QueryFirstOrDefault<ArticlesEntity>("SELECT * FROM Articles WHERE Articles_Id = @Articles_Id", new { Articles_Id = articlesId });

        }

        public void InsertArticle(ArticlesEntity article)
        {
            _connection.Open();
            _connection.Execute("INSERT INTO Articles (Titre, Contenue, Date_publication) VALUES (@Titre, @Contenue, @Date_publication)", article);
        }

    }
}
