namespace Homework4
{
    class Instructor : Person, IEmployee
    {
        private string? department;

        public Instructor(string firstName, string lastName, int id, string? department) : base(firstName, lastName, id)
        {
            Department = department;
        }
        public override string ToString()
        {
            return $"Prof. {lastName} ({id}) [Dept. of {department}] ($<salary>)";
        }
        public void Salary(double salary) { }
        public string? Department
        {
            get => department;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(department));
                }
                department = value;
            }
        }
    }
}
