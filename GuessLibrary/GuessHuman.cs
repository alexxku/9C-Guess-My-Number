using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessLibrary
{
    public class GuessHuman
    {
        public static void Play()
        {
            int RandomNumber = Generate.RandomNumber(1, 100);
            int GuessedNumber;
            Console.WriteLine("The computer had generated a random number from 1-1000. Guess the number that the computer had generated.");
            Restart:
            Console.Write("Enter a number: ");
            try
            {
                GuessedNumber = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message.ToString());
                goto Restart;
            }

                while (GuessedNumber != RandomNumber)
            {
                if (GuessedNumber > RandomNumber)
                {
                    Console.WriteLine("The number you have guessed is too high.");
                    RestartTwo:
                    Console.Write("Number: ");
                    try
                    {
                        GuessedNumber = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message.ToString());
                        goto RestartTwo;
                    }
                }
                else if (GuessedNumber < RandomNumber)
                {
                    Console.WriteLine("The number you have guessed is too low.");
                    RestartTwo:
                    Console.Write("Number: ");
                    try
                    {
                        GuessedNumber = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message.ToString());
                        goto RestartTwo;
                    }
                }
            }

            Console.WriteLine($"You guessed the number ! The number was {RandomNumber} !");
        }
    }
}
