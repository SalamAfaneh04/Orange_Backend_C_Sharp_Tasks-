using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Categories_And_Products.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }

        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }  // This handles the file upload
        public string? Image { get; set; }          // This stores the file path

        // Many Products --> One Category (FK)
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
