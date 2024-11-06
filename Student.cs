namespace Homework4
{
    class Student : Person
    {
        protected string? major;
        protected string? minor;
        protected double gpa;

        public Student(string firstName, string lastName, int id, string? major, string? minor, double gpa) : base(firstName, lastName, id)
        {
            Major = major;
            Minor = minor;
            GPA = gpa;
        }
        public override string ToString()
        {
            string Major;
            string Minor;
            if (string.IsNullOrWhiteSpace(major)) { Major = "Undeclared"; }
            else { Major = major; }
            if (string.IsNullOrWhiteSpace(minor)) { Minor = "Undeclared"; }
            else { Minor = minor; }

            return $"{lastName}, {firstName} ({id}) [{Major} Major / {Minor} Minor] GPA: {gpa}";
        }
        public string? Major
        {
            get => major;
            set => major = value;
        }
        public string? Minor
        {
            get => minor;
            set => minor = value;
        }
        public double GPA
        {
            get => gpa;
            set
            {
                if (value < 0 || value > 4) { throw new ArgumentOutOfRangeException(nameof(gpa)); }
                gpa = value;
            }
        }
    }
}
