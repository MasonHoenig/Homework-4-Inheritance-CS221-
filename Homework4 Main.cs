namespace Homework4
{
    class Homework
    {
        public static void Main()
        {
            Student Jared = new("Jared", "Hanson", 2315213, "Business Administration", "Finance", 3.2);
            Student Tina = new("Tina", "Cunningham", 1021548, "Social Work", "Psychology", 3.85);
            Student Jacob = new("Jacob", "Stevenson", 5215426, "Journalism", "Communications", 2.5);

            Instructor Steven = new("Steven", "Jacobson", 1005246, "Computer Science", 60000);
            Instructor Jenny = new("Jenny", "Milton", 4547814, "Social Sciences", 70000);
            Instructor Ben = new("Ben", "Thomson", 2101547, "Biology", 40000);

            GraduateStudent Kathy = new("Kathy", "Smith", 5521452, "Education", 3.9, 6000);
            GraduateStudent Rebecca = new("Rebecca", "Oswald", 9981875, "Political Science", 4.0, 5000);
            GraduateStudent Peter = new("Peter", "Griffin", 8979851, "Computer Science", 3.1, 2000);

            Person[] myUniversity = { Jared, Tina, Jacob, Steven, Jenny, Ben, Kathy, Rebecca, Peter };

            Console.WriteLine("Everyone at the University:");
            for (int i = 0; i < myUniversity.Length; i++)
            {
                Console.WriteLine(myUniversity[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Graduate Students at the University:");
            for (int i = 0; i < myUniversity.Length; i++)
            {
                if (myUniversity[i] is GraduateStudent)
                {
                    Console.WriteLine(myUniversity[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Average GPA of all students at the university:");
            int count = 0;
            double gpaTotal = 0;

            for (int i = 0; i < myUniversity.Length; i++)
            {
                if (myUniversity[i] is Student student)
                {
                    gpaTotal += student.GPA;
                    count++;
                }
            }
            double gpaAverage = gpaTotal / count;
            Console.WriteLine(Math.Round(gpaAverage, 3));

            Console.WriteLine();

            Person? highestEarner = null;
            Person? lowestEarner = null;

            for (int i = 0; i < myUniversity.Length; i++)
            {
                if(myUniversity[i] is IEmployee)
                {
                    highestEarner = myUniversity[i];
                    lowestEarner = myUniversity[i];
                    break;
                }
            }

            for (int i = 0; i < myUniversity.Length; i++)
            {
                if (myUniversity[i] is IEmployee employee)
                {
                    if (employee.Salary > ((IEmployee)highestEarner).Salary)
                    {
                        highestEarner = myUniversity[i];
                    }
                    if (employee.Salary < ((IEmployee)lowestEarner).Salary)
                    {
                        lowestEarner = myUniversity[i];
                    }
                }
            }
            Console.WriteLine("Highest paid Employee:");
            Console.WriteLine(highestEarner);

            Console.WriteLine();

            Console.WriteLine("Lowest paid Employee: ");
            Console.WriteLine(lowestEarner);
        }
    }
}