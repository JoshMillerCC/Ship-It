using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    class Baseball_Glove : IShippable
    {
        public decimal ShipCost => 3.23m;

        public string Product => "Baseball Glove";
    }
}
