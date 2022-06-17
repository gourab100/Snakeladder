using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLedder
{
    internal class Snakeladder
    {
        public void Start()
        {
            int position;
            int playerone = 3;
            Console.WriteLine("playerone position " + playerone);
            while( playerone <= 100)
            {
                position = rolldice();

                // noplay condition

                if (position == 0)
                {
                    Console.WriteLine("no play");
                    playerone += position;
                }

                //  Snake bite condition

                if (playerone == 0 && position < 0)  
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerone = 0; 
                }

                if (playerone > 0 && position < 0)
                {
                    Console.WriteLine("Snakebite");
                    playerone += position;
                    if (position < 0)
                    {
                        playerone = 0;
                    }
                }

                // ladder condition

                if (position > 0)
                {
                    Console.WriteLine("ladder");
                    playerone += position;
                }

                Console.WriteLine(" after rolling player1 position " + playerone);

            }
        }

        public int rolldice()
        {
            Random random = new Random();

            int dice = random.Next(1, 7);
            Console.WriteLine("dice :" + dice);
            int check = random.Next(1, 4);
            if (check == 1)
                return -dice; // snakebite;
            if (check == 2)
                return dice; // ladder
            else
                return 0;
        }

    }
}
