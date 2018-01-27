using System;
using System.Collections.Generic;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Torsos;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Child,
                NumberOfPockets = 4
            };

            var head = new Emmet
            {
                EyeColor = "Blue",
                Happy = true,
                HeadGear = new Hair { Color = "blonde", Length = "long" }
            };

            var body = new DadBod
            {
                BeerBelly = true,
                BodyHair = true,
                NumberOfNipples = 2,
                Shirt = "purple"
            };

            var dadEmmet = new Minifigure(jeans, head, body, "Emmet");


            dadEmmet.Walk(50);
        }
    }
}
