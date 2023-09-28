using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Omnivore:Animal
    {
        public Omnivore(string name, double weight) : base(name, weight)
        {
        }

        public override void FoodInfo()
        {
            foodAmount = weight * 0.3;
            foodType = "Everything";
        }
    }
}
