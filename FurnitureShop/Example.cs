using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop
{
    public static class Example
    {
        public static void CreateItems()
        {
            Furniture chair = new Furniture();
            chair.name = "Chair";
            chair.price = 300.5;
            chair.manufacturer = "Ukraine";
            Console.WriteLine($"We have {nameof(chair)}s at a price of {chair.price}, manufactured in {chair.manufacturer}.");

            Raw fiberboard = new Raw();
            fiberboard.name = "Chair";
            fiberboard.price = 71.52;
            Dimensions d = new Dimensions(214, 0.32, 366);
            fiberboard.dimensionsInCm = d;
            Console.WriteLine($"We have {nameof(fiberboard)}s at a price of {fiberboard.price}, dimensions {fiberboard.dimensionsInCm.Height}x{fiberboard.dimensionsInCm.Width}x{fiberboard.dimensionsInCm.Length} cm.");
        }
    }
}
