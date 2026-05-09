using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Categories_And_Products.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        public string CategoryName { get; set; }

        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }  // This handles the file upload
        public string? Image { get; set; }          // This stores the file path

        // One Category --> Many Products
        public ICollection<ProductModel> Products { get; set; }
    }
}
