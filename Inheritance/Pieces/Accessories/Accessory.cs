using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Accessories
{
    class AccessoryBase
    {
        public abstract AccessoryLocation Location { get; set; }
    }

        enum AccessoryLocation
        {
            Hand = 1,
            Torso
        }
}
