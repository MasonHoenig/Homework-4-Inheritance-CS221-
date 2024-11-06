namespace Homework4
{
    class GraduateStudent : Student, IEmployee
    {
        private double salary;
        public GraduateStudent(string firstName, string lastName, int id, string? major, double gpa, double salary) : base(firstName, lastName, id, major, null, gpa)
        {
            if (string.IsNullOrWhiteSpace(major)) { throw new ArgumentNullException(nameof(major)); }
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{lastName}, {firstName} ({id}) [Studying {major}] GPA: {gpa} (${salary})";
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
    }
}