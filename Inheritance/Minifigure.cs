using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Pieces.Accessories;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Torsos;

namespace Inheritance
{
    class Minifigure
    {
        public string Name { get; private set; }
        public LegBase Legs { get; set; }
        public HeadBase Head { get; set; }
        public TorsoBase Torso { get; set; }

        public Minifigure(LegBase legs, HeadBase head, TorsoBase torso, string name)
        {
            Name = name;
            Legs = legs;
            Head = head;
            Torso = torso;
        }

        public void Walk(int numberOfSteps)
        {
            switch (Head.HeadGear)
            {
                case Hair hair:
                    Console.WriteLine($"{Name} tossed his {hair.Length} {hair.Color} hair in the wind.");
                    break;
                case Helmet helmet:
                    Console.WriteLine($"{Name} wondered why he is wearing a {helmet.Color} helmet.");
                    break;
            }

            foreach (var accessory in Torso.Accessories)
            {

            }
            
            Legs.Walk(numberOfSteps);
        }

        public void SwapTorso(TorsoBase torso)
        {
            if (torso == null)
            {
                throw new ArgumentNullException(nameof(torso));
            }
        }

        public void Accessorize(AccessoryBase accessory)
        {
            Torso.Accessories.Add(accessory);
        }
    }


}
