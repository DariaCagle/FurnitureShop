using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureShop
{
    public abstract class Item
    {
        public string name;
        public double price;

    }

    class Furniture : Item
    {
        public string manufacturer;

    }

    class Raw : Item
    {
        public Dimensions dimensionsInCm;
    }
}
