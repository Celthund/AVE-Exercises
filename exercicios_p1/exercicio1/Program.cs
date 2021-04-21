using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, "Tiago", new School("Isel", "Lisboa"), "Portugues");
            Student s2 = new Student(12, "Tiago", new School("Isel", "Lisboa"), "Portugues");
            IEquality eq1 = new Equality(typeof(Student), "Nr", "Name", "School");
            bool res1 = eq1.AreEqual(s1, s2); // res1 = true se s1 e s2 tiverem o mesmo Nr, Name e School
            IEquality eq2 = new Equality(typeof(Student), "Nr", "Nationality");
            bool res2 = eq2.AreEqual(s1, s2); // res2 = true se s1 e s2 tiverem o mesmo Nr e Nationality
            Console.WriteLine("res1: " +  res1 + " res2:" + res2);
        }
    }
}
