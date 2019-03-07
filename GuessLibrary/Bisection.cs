using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessLibrary
{
    public class Bisection
    {
        static public int [] Search(int x, int[] Array)
        {
            int middlePoint = Array.Length / 2;
            int[] BisectedArray = new int[(int)Math.Ceiling(Array.Length / 2.0)];

            if (x == Array[middlePoint])
            {
                int[] FinalArray = { Array[middlePoint] };
                return FinalArray;
            }
            else if (x > Array[middlePoint])
            {
                for (int element = 0; element < BisectedArray.Length; element++)
                {
                    BisectedArray[element] = Array[middlePoint];
                    middlePoint++;
                }
            }
            else if (x < Array[middlePoint]) 
            {
                for(int element = 0; element < BisectedArray.Length; element++)
                {
                    BisectedArray[element] = Array[element];
                    
                }
            }

            return BisectedArray;
        }
    }
}
