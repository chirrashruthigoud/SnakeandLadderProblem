using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class SnakeLadderClass
    {
        public void LadderMethod()
        {
            int position = 0;

            Random random = new Random();
            int dice = random.Next(1, 7);

            int option = random.Next(0, 3);
            if (option == 0)
            {
                Console.WriteLine("Player stays at same Position");
            }
            else if (option == 1)
            {
                Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
                position += dice;
            }
            else
            {
                Console.WriteLine("Player Moves Behind by {0} from Snake", dice);
                position -= dice;
            }
            Console.WriteLine("Current Position is at : {0}", position);
        }
    }
}
