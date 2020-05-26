using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    class Crackers : IShippable
    {
        public decimal ShipCost => 0.57m;

        public string Product => "Crackers";
    }
}
