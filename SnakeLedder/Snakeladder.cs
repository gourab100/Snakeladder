using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLedder
{
    internal class Snakeladder
    {
        const int WIN_POSITION = 100;
        const int START_POSITION = 0;

        public void Start()
        {
            int player;
            int playerOne = START_POSITION, playerTwo = START_POSITION;    
            Console.WriteLine($"player One position is " + playerOne); 
            Console.WriteLine($"player Two position is "+ playerTwo); 
            
            int turn = 1; 
            while (true) 
            {
                if (turn == 1) 
                {
                    Console.WriteLine(" PLAYER ONE TURN");
                    player = PlayGame(playerOne, turn); 
                    turn = 0; 
                    if (player > playerOne) 
                    {
                        turn = 1;
                    }
                    playerOne = player; 
                }
                if (playerOne == WIN_POSITION) 
                {
                    Console.WriteLine("  PLAYER ONE WINS  ");
                    break; // player one wins the game
                }
                if (turn == 0)
                {
                    
                    Console.WriteLine(" PLAYER TWO TURN");
                    player = PlayGame(playerTwo, turn);
                    turn = 1; 
                    if (player > playerTwo) 
                    {
                        turn = 0;
                    }
                    playerTwo = player; 
                }
                if (playerTwo == WIN_POSITION) 
                {
                    Console.WriteLine("   PLAYER TWO WINS   ");
                    break; //player 2 wins the game
                }
            }
        }



        public int PlayGame( int playerposition, int turn)
        {
            int position;    
            int checkwin;
            while (playerposition != WIN_POSITION) 
            {
               
                checkwin = CheckWin(playerposition);
                if (checkwin == 1 && turn == 1) 
                {
                    Console.WriteLine("player One wins!!");
                    break; 
                }
                if (checkwin == 1 && turn == 0) 
                {
                    Console.WriteLine("player Two wins!!");
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
                    playerposition += position;
                }

                //snake condition
                if (playerposition == 0 && position < 0)   
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerposition = 0; 
                }
                if (playerposition > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    playerposition += position; 
                    if (playerposition < 0)
                    {
                        
                        playerposition = 0;
                    }
                }

                //ladder condition
                if (position > 0)
                {
                    Console.WriteLine("its a ladder"); 
                    playerposition += position;
                }
                if (playerposition > WIN_POSITION)
                {
                    playerposition -= position; 
                }
                if (turn == 1) 
                {
                    Console.WriteLine("Player One rolls die and gets position " + playerposition);
                    break;
                }
                if (turn == 0) 
                {
                    Console.WriteLine($"Player Two rolls die and get position " + playerposition);
                    break;
                }
            }
            return playerposition; 
        }





        public int CheckWin(int playerOne)
        {
            if (playerOne == WIN_POSITION) 
                return 1;
            if (playerOne > WIN_POSITION) 
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
