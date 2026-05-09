using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class DepartmentModel
    {
        [Display(Name = "Department Id")]
        public int Id { get; set; }
        [Display(Name ="Department Name")]
        [Required]
        public string DeptName { get; set; }

        //One Department --> Many Employees
        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
