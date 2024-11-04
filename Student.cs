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
            if (string.IsNullOrWhiteSpace(major)) { major = "Undeclared"; }
            if(string.IsNullOrWhiteSpace(minor)) { minor = "Undeclared"; }

            return $"{lastName}, {firstName} ({id}) [{major} Major / {minor} Minor] GPA: {gpa}";
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
