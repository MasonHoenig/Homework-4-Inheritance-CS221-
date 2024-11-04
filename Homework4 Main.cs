namespace Homework4
{
    class Homework
    {
        public static void Main()
        {
            Student Jared = new("Jared", "Hanson", 2315213, "Business Administration", "Finance", 3.2);
            Instructor Steven = new("Steven", "Jacobson", 1005246, "Computer Science");
            GraduateStudent Kathy = new("Kathy", "Smith", 5521452, "Education", "", 3.9);

            Steven.Salary(60000);
            Kathy.Salary(10000);

            Person[] people = {Jared, Steven, Kathy};

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] is IEmployee)
                {
                    IEmployee? Salary = people[i] as IEmployee;
                    Salary.Salary(10000);
                }
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}