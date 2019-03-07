using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessLibrary;

namespace _9C_Guess_My_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Implement.BisectAlgorithm();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            GuessHuman.Play();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            GuessComputer.Play();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
