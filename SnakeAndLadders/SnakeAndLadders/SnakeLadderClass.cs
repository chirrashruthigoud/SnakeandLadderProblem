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
            int numberOfTimesDiceRolled = 0;

            while (position < 100)
            {
                int temp = position;
                int dice = random.Next(1, 7);
                numberOfTimesDiceRolled++;

                Console.WriteLine($"The Player rolls a dice and gets: {dice}");
                Console.WriteLine($"Number of Times Dice rolled is: {numberOfTimesDiceRolled}");

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

                if (position < 0)
                {
                    position = 0;
                }
                else if (position > 100)
                {
                    position = temp;
                }
                Console.WriteLine("Player Current Position is at : {0}", position);
            }
            Console.WriteLine("Player is at Position : {0}", position);
            Console.WriteLine($"Total Number of Times Dice rolled is: {numberOfTimesDiceRolled}");
        }
    }
}
