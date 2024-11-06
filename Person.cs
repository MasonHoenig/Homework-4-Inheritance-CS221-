namespace Homework4
{
    abstract class Person
    {
        protected string? firstName;
        protected string? lastName;
        protected int id;

        public Person( string firstName, string lastName, int id)
        {
            if (id < 1000000 || id > 9999999) { throw new ArgumentOutOfRangeException(nameof(id)); }

            FirstName = firstName;
            LastName = lastName;
            this.id = id;
        }
        public string? FirstName
        {
            get => firstName;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) { throw new ArgumentNullException(nameof(firstName)); }
                firstName = value;
            }
        }
        public string? LastName
        {
            get => lastName;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) { throw new ArgumentNullException(nameof(lastName)); }
                lastName = value;
            }
        }
        public int ID
        {
            get => id;
        }
    }
}