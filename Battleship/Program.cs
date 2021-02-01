using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player();

            playerOne.AttackOpponentX();
            Console.SetBufferSize(800, 800);

            int me = 0;
            int[,] arr2d = new int[20, 20];
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    arr2d[x, y] = 0;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("{0}\t", arr2d[i,j]);
                }
            }
           
            Console.ReadLine();


        }
    }
}
