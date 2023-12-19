using System.ComponentModel.DataAnnotations;

namespace PetCareConnectApi.Models.Forms
{
    public class CreateArticleForm
    {
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Contenue { get; set; }
    }
}
