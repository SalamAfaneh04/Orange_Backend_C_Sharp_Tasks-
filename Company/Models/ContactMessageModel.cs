using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class ContactMessageModel
{
        public int Id { get; set; }

        [Display(Name = "Sender Name")]
        [Required]
        public string SenderName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Message")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Sent At")]
        public DateTime SentAt { get; set; } = DateTime.Now;
    
    }
}
