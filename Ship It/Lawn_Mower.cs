using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    class Lawn_Mower : IShippable
    {
        public decimal ShipCost => 24.00m;

        public string Product => "Lawn Mower";
    }
}
