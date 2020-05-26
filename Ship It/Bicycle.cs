using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    class Bicycle : IShippable
    {
        public decimal ShipCost => 20.50m;

        public string Product => "Bicycle";
    }
}
