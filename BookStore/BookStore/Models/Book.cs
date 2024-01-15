using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }  
        public float Price {  get; set; }

       public string? CoverImg { get; set; }

       [NotMapped]
       public IFormFile? ImageFile { get; set; }
    }
}
