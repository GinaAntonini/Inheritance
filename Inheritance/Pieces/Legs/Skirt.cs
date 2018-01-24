using System;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase, IMoveable
    {
        public string Material { get; set; }
        public Length Length { get; set; }
        int _howFarIMoved;

        public int HowFarIMoved
        {
            get => _howFarIMoved;
        } 

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches.");
        }

        public void Run(int howFar)
        {
            _howFarIMoved += howFar;
            Console.WriteLine($"Skirt ran {howFar} miles uphill both ways.");
        }

        public void Walk(int numberOfSteps) 
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively and knocked on your window.");
                return;
            }

            _howFarIMoved += numberOfSteps;

            base.Walk(numberOfSteps);
        }
    }
}
