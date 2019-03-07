using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessLibrary
{
    public class Implement
    {
        static int[] List = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static void BisectAlgorithm()
        {
            int Value;
            Restart:
            Console.Write("Input a Number from 1-10: ");
            try
            {
                Value = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message.ToString());
                goto Restart;
            }
            int[] NewList = Bisection.Search(Value, List);

            int Step = 1;

            while (NewList.Length != 1)
            {
                Console.Write($"\nStep {Step}: --- ");

                foreach (int x in NewList)
                {
                    Console.Write($"{x} ");
                }

                Console.WriteLine("---");

                NewList = Bisection.Search(Value, NewList);

                Step++;
            }

            Console.WriteLine($"\nStep {Step}: --- {NewList[0]} ---");

        }
    }
}
