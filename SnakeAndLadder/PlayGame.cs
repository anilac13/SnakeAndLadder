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
            const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            Console.WriteLine("Die number is: " + rollDie);
            int option = random.Next(3);
            switch (option)
            {
                case NO_PLAY:
                    playerPosition = 0;
                    break;
                case LADDER:
                    playerPosition += rollDie;
                    Console.WriteLine("Player position ===> " + playerPosition);
                    break;
                case SNAKE:
                    playerPosition -= rollDie;
                    Console.WriteLine("Player position ===> " + playerPosition);
                    break;
            }
        }
    }
}
