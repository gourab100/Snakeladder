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
            int playerOne = 3;    
            int checkwin;
            Console.WriteLine("player One position is " + playerOne);
            while (playerOne <= 100)
            {
                
                checkwin = CheckWin(playerOne);
                if (checkwin == 1) 
                {
                    Console.WriteLine("playerOne wins!!");
                    break; 
                }
                if (checkwin == 2) 
                {
                    position = 0;
                }
                else 
                {
                    position = RollDiec();
                }
                // No play condition
                if (position == 0)
                {
                    Console.WriteLine("its a no play");
                    playerOne += position;
                }

                //snake condition
                if (playerOne == 0 && position < 0)  
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerOne = 0; 
                }
                if (playerOne > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    playerOne += position; 
                    if (playerOne < 0)
                    {
                        
                        playerOne = 0;
                    }
                }

                //ladder condition
                if (position > 0)
                {
                    Console.WriteLine("its a ladder"); 
                    playerOne += position;
                }
                if (playerOne > 100)
                {
                    playerOne -= position; 
                }
                Console.WriteLine($"player One rolls die and get position "+ playerOne);
            }
        }

        public int CheckWin(int playerOne)
        {
            if (playerOne == 100) 
                return 1;
            if (playerOne > 100) 
                return 2;
            else 
                return 0;
        }


         Random random = new Random();
        int countdice = 0;
        public int RollDiec()
        {
            int dice, check;
            dice = random.Next(1, 7);
            countdice++;
            Console.WriteLine("number " + countdice);
            Console.WriteLine("Dice = " +dice);
            check = CheckPlay();
            
            if (check == 1)
                return -dice; 
            if (check == 2)
                return dice; 
            else
                return 0; 
        }

        public int CheckPlay()
        {
            
            int check = random.Next(1, 4);
            return check;
        }
        

    }
}
