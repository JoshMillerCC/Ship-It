using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
