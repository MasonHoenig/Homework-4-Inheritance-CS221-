namespace Homework4
{
    class GraduateStudent : Student, IEmployee
    {
        public GraduateStudent(string firstName, string lastName, int id, string? major, string? minor, double gpa) : base(firstName, lastName, id, major, minor, gpa)
        {
            if (string.IsNullOrWhiteSpace(major)) { throw new ArgumentNullException(nameof(major)); }
        }
        public override string ToString()
        {
            return $"{lastName}, {firstName} ({id}) [Studying {major}] GPA: {gpa} ($<salary>)";
        }
        public void Salary(double salary) { }
    }
}
