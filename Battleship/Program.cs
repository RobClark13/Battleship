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
            int[,] arr2d = new int[4, 4];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    arr2d[x, y] = x+y;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", arr2d[i,j]);
                }
            }
           
            Console.ReadLine();


        }
    }
}
