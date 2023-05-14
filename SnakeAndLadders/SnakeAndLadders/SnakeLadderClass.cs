using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class SnakeLadderClass
    {
        public void SinglePlayer()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine($"The Player rolls a dice and gets: {dice}");
        }
    }
}
