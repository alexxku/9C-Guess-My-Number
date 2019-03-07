using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessLibrary
{
    public class Generate
    {

        public static int RandomNumber(int x, int y)
        {
            Random random = new Random();

            return random.Next(x, y);
        }
        
    }
}
