namespace Homework4
{
    class Instructor : Person, IEmployee
    {
        private string? department;
        private double salary;

        public Instructor(string firstName, string lastName, int id, string? department, double salary) : base(firstName, lastName, id)
        {
            Department = department;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Prof. {lastName} ({id}) [Dept. of {department}] (${salary})";
        }
        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(salary));
                }
                salary = value;
            }
        }
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
