namespace exercises
{
    using System;
    using System.Linq;

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;


        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;        
        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            testScores = scores;
        }
       
        public string Calculate()
        {
            string retorno = "T";
            int nota = 0;
            if (testScores != null)
            {
                nota = testScores.Sum();
                nota = nota / 2;
            }
            if (nota < 40)
            {
                retorno = "T";
            }
            else if (nota < 55)
            {
                retorno = "D";
            }
            else if (nota < 70)
            {
                retorno = "P";
            }
            else if (nota < 80)
            {
                retorno = "A";
            }
            else if (nota < 90)
            {
                retorno = "E";
            }
            else if (nota <= 100)
            {
                retorno = "O";
            }
            return retorno;
        }
    }

    public class testeInheritance
    {
        public static void run()
        {
            string firstName = "Davidson";
            string lastName = "Rocha";
            int id = 1;
            int[] scores = { 90, 100 };
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}