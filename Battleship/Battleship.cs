using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battleship : Ship
    {
        //member variables

        //constructor
        public Battleship()
        {
            shipName = "Battleship";
            shipLength = 4;
            shipSunk = false;
            shipSymbol = 'B';
        }

        //member methods
    }
}
