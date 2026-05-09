using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class EmployeeModel
    {
        //Primary Key
        [Display(Name ="Employee Id")]
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        [Required]
        public string EmpName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)] // Renders the HTML5 date picker in the View
        public DateOnly? BirthDate { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^07[789]\d{7}$", ErrorMessage = "Invalid format. Must start with 07(7,8,9) and be 10 digits total.")] 
        public string? PhoneNumber { get; set; }

        [Display(Name ="National ID")]
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid format. Must Contain 10 digits.")]
        public string NationalID {  get; set; }

        [Display(Name ="Nationality")]
        public string? Nationality { get; set; }

        [Display(Name = "Marital Status")]
        public string? MaritalStatus { get; set; }

        [Display(Name ="Photo")]
        public string? Photo { get; set; }

        [Display(Name ="Entry Date")]
        [DataType(DataType.Date)] // Renders the HTML5 date picker in the View
        public DateOnly? EntryDate { get; set; }

        [Display(Name ="Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Role")]
        [Required]
        public string Role { get; set; }

        [Display(Name = "Department Id")]
        [Required]
        //Many Employees --> One Department
        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }

        //One Employees --> Many Tasks
        public ICollection<TaskModel> Tasks { get; set; }

    }
}
