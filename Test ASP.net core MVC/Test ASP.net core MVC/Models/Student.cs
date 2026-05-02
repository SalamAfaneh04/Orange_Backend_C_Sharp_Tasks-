namespace Test_ASP.net_core_MVC.Models
{
    public class Student
    {
        private string _name;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = (value < 0)? value : 0; }
        }
        public int Id { get; set; }
        public string Name {
            get { return _name; } 
            set {_name = ( value != null) ? value: "User"; }
        }
        public string Description { get; set; }
        public double Gpa { get; set; }
        public string Password { get; set; }

    }
}
