using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayGame
    {
        public static void Play()
        {
            int playerPosition = 0;
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            Console.WriteLine("Die number is: " + rollDie);
        }
    }
}
