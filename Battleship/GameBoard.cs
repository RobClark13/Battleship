using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class GameBoard
    {
        //member variables
        public char[,] gameboard;
        public char hit = 'H';
        public char miss = 'M';
        //constructor
        public GameBoard()
        {
            gameboard = new char[20, 20];
        }
        //member methods
        public void FillGameBoard()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    this.gameboard[i, j] = 'O';
                }
            }
        }

        public void CheckBoard(int xCoor, int yCoor)
        {
            if (gameboard[xCoor,yCoor] == 'O')
            {
                gameboard[xCoor, yCoor] = miss;
            }
            else if (gameboard[xCoor, yCoor] == 'M' || gameboard[xCoor, yCoor] == 'H')
                
            {
                Console.WriteLine("You already guessed this spot. Try Again");
            }
            else
            {
                gameboard[xCoor, yCoor] = hit;
            }
        }
        public void ViewOppenentBoard()
        {

        }
        public void ViewOwnBoard()
        {

        }
    }
}
