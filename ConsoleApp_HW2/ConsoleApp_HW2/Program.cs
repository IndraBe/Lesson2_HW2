﻿using System;

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

            int notAdult = 17;

            bool isAdult = nextYearAge > notAdult;

            Console.WriteLine("Sveiks, Tev nākamgad paliks: " + nextYearAge);
            Console.WriteLine(isAdult ? "tu esi pilngadīgs. " : "tu neeesi pilngadīgs. ");

            //------------------------------------------------------
            Console.WriteLine("=======================================");

            Console.WriteLine("Lūdzu, norādi 1. skaitli:");
            string Number1 = Console.ReadLine();
            int randomNr1 = int.Parse(Number1);

            Console.WriteLine("Lūdzu, norādi 2. skaitli:");
            string Number2 = Console.ReadLine();
            int randomNr2 = int.Parse(Number2);

            int maxResult = Math.Max(randomNr1, randomNr2);

            Console.WriteLine("Lielākais no piedāvātajiem skaitļiem ir: " + maxResult);

            //------------------------------------------------------
            Console.WriteLine("Lūdzu, norādi 1. skaitli:");
            string Number3 = Console.ReadLine();
            int randomNr3 = int.Parse(Number3);

            Console.WriteLine("Lūdzu, norādi 2. skaitli:");
            string Number4 = Console.ReadLine();
            int randomNr4 = int.Parse(Number4);

            int minResult = Math.Min(randomNr3, randomNr4);

            Console.WriteLine("Mazākais no piedāvātajiem skaitļiem ir: " + minResult);


        }
    }
}
