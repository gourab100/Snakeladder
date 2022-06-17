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
            int position = 0;
            int playerone;
            playerone = position;
            Console.WriteLine("playerone position " + playerone);
            playerone = rolldice();
            Console.WriteLine(" after rolling player1 position " + playerone);

        }

        public int rolldice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }

    }
}
