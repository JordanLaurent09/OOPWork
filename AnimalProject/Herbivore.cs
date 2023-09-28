using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Herbivore:Animal
    {
        public Herbivore(string name, double weight) : base(name, weight)
        {
        }

        public override void FoodInfo()
        {
            foodAmount = weight * 0.7;
            foodType = "Vegetables";
        }
    }
}
