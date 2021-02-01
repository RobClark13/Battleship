using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        //member variables
        string name;
        Fleet playerFleet;

        //constructor
        public Player()
        {
            name = "";
            playerFleet = new Fleet();
        }

        //member methods
        public void PlaceFleet()
        {

        }
        public int AttackOpponentX()
        {
            Console.WriteLine("What is the X-Coordinate of the spot you want to attack?");
            string userXCoor = Console.ReadLine();
            int xCoor;
            bool success = Int32.TryParse(userXCoor, out xCoor);
            if (success == true && xCoor >= 0 && xCoor < 19)
            {
                return xCoor;
            }
            else
            {
                Console.WriteLine("Please enter a number 0-19");
                AttackOpponentX();
            }
            return -10;
        }
        public int AttackOpponentY()
        {
            Console.WriteLine("What is the Y-Coordinate of the spot you want to attack?");
            string userYCoor = Console.ReadLine();
            int yCoor;
            bool success = Int32.TryParse(userYCoor, out yCoor);
            if (success == true && yCoor >= 0 && yCoor < 19)
            {
                return yCoor;
            }
            else
            {
                Console.WriteLine("Please enter a number 0-19");
                AttackOpponentX();
            }
            return -10;
        }
    }
}
