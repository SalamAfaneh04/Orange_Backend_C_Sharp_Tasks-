using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public enum TaskImportance
    {
        Low,
        Medium,
        High,
        Critical
    }
    public class TaskModel
    {
        public int Id { get; set; }
        

        [Display(Name ="Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Display(Name = "Due Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DueDate { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }


        [Display(Name = "Level Of Importance")]
        [Required]
        public TaskImportance LevelOfImportance { get; set; }

        [Display(Name = "Employee")]
        //Many Tasks --> One Employees
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }




    }
}
