using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Torsos;

namespace Inheritance
{
    class Minifigure
    {
        public string Name { get; set; }
        public LegBase Legs { get; private set; }
        public HeadBase Head { get; private set; }
        public TorsoBase Torso { get; private set; }

        public Minifigure(LegBase legs, HeadBase head, TorsoBase torso, string name)
        {
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
            
            Legs.Walk(numberOfSteps);
        }
    }


}
