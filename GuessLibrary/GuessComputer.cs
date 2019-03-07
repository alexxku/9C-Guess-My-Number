using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessLibrary
{
    public class GuessComputer
    {
        public static void Play()
        {
            int ChosenNumber;
            string Decision;
            Console.WriteLine("You will choose a number from 1-100. The computer will guess the number that you have chosen.");
            RestartOne:
            Console.Write("Enter the chosen number: ");
            try
            {
                ChosenNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message.ToString());
                goto RestartOne;
            }
            while (!(ChosenNumber <= 100))
            {
                Console.WriteLine("Invalid Number. Please Try Again.");
                RestartTwo:
                Console.Write("Enter the chosen number: ");
                try
                {
                    ChosenNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message.ToString());
                    goto RestartTwo;
                }
            }    
            RestartThree:
            int Min = 1;
            int Max = 100;
            int GuessedNumber = Generate.RandomNumber(Min, Max);

            int repeatsNumber = 0;

            while (GuessedNumber != ChosenNumber)
            {
                repeatsNumber++;
                Console.WriteLine($"The computer has guessed the number {GuessedNumber}. Should the computer go (higher) or (lower)?");
                Console.Write("Decision: ");
                Decision = Console.ReadLine().ToLower();

                while(Decision != "lower" && Decision != "higher")
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                    Console.Write("Decision: ");
                    Decision = Console.ReadLine().ToLower();
                }
                if (Decision == "lower")
                {
                    Max = GuessedNumber - 1;              
                    if (Max < ChosenNumber)
                    {
                        Console.WriteLine($"You had told the computer to go lower when the chosen number is {ChosenNumber}.\nRestarting guess.");
                        goto RestartThree;
                    }
                }
                else if (Decision == "higher")
                {
                    Min = GuessedNumber + 1;
                    if (Min > ChosenNumber)
                    {
                        Console.WriteLine($"You had told the computer to go higher when the chosen number is {ChosenNumber}.\nRestarting guess.");
                        goto RestartThree;
                    }
                }

                GuessedNumber = Generate.RandomNumber(Min, Max);
            }

            Console.WriteLine($"The computer guessed the number ! The number the computer guessed is {GuessedNumber} ! The number of repeats is {repeatsNumber}.");
        }
    }
}
