using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayGame
    {
        int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int count = 0;
        Random random = new Random();
        public int RollDie()
        {
            int rollDie = random.Next(1, 7);
            Console.WriteLine("Die value: " + rollDie);
            count++;
            return rollDie;
        }
        public int Play()
        {
            while (this.playerPosition < WINNING_POSITION)
            {
                int option = random.Next(3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += RollDie();
                        Console.WriteLine("Player position ===> " + playerPosition);
                        break;
                    case SNAKE:
                        int roll = RollDie();
                        if (this.playerPosition- roll > 0)
                        {
                            this.playerPosition -= roll;
                        }
                        else
                        {
                            this.playerPosition = 0;
                        }
                        break;
                }
                Console.WriteLine("Player position ===> " + playerPosition);
            }
            if (this.playerPosition == WINNING_POSITION)
            {
                Console.WriteLine("Player Position--->  " + playerPosition);
                Console.WriteLine("Die Count " + count);
            }
            return playerPosition;
        }
        public void TwoPlayers(int player1, int player2)
        {
            if (player1 == WINNING_POSITION)
                Console.WriteLine("Player 1 Won the Game");
            if (player2 == WINNING_POSITION)
                Console.WriteLine("Player 2 Won the Game");
        }
    }
}
