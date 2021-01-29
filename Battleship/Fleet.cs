using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Fleet
    {
        //member variables
        public List<Ship> fleetList = new List<Ship>
        {
            new AircraftCarrier(),
            new Battleship(),
            new Destroyer(),
            new Submarine()
        };
        //constructor
        

        //member methods
    }
}
