using System;

namespace ConsoleApp_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā Tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);

            //------------------------------------------------------

            Console.WriteLine("Kāds ir Tavs vecums?");

            string ageNumber = Console.ReadLine();

            int age = int.Parse(ageNumber);
            int nextYearAge = age + 1;

            Console.WriteLine("Sveiks, Tev nākamgad paliks: " + nextYearAge);

        }
    }
}
