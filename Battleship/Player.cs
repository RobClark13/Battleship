using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        //member variables
        public string name;
        public Fleet playerFleet;
        public GameBoard playerGameBoard;

        //constructor
        public Player()
        {
            name = "";
            playerFleet = new Fleet();
            playerGameBoard = new GameBoard();
        }

        //member methods
        public void PlaceFleet()
        {
            for (int  i = 0;  i <playerFleet.fleetList.Count;  i++)
            {
                Console.WriteLine(playerFleet.fleetList[i].shipName);
            }
        }
        
        public int GetXCoor()
        {
            Console.WriteLine("What is the X-Coordinate?");
            string userXCoor = Console.ReadLine();
            int xCoor;
            bool success = Int32.TryParse(userXCoor, out xCoor);
            if (success == true && xCoor >= 0 && xCoor < 20)
            {
                return xCoor;
            }
            else
            {
                Console.WriteLine("Please enter a number 0-19");
                return GetXCoor();
            }
        }
        public int GetYCoor()
        {
            Console.WriteLine("What is the Y-Coordinate?");
            string userYCoor = Console.ReadLine();
            int yCoor;
            bool success = Int32.TryParse(userYCoor, out yCoor);
            if (success == true && yCoor >= 0 && yCoor < 20)
            {
                return yCoor;
            }
            else
            {
                Console.WriteLine("Please enter a number 0-19");
                return GetYCoor();
            }
            
        }
    }
}
