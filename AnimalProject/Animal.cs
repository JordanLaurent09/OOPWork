using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    abstract class Animal
    {
        public string name;
        public double weight;
        public double foodAmount;
        public double id;
        public string foodType;

        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public abstract void FoodInfo();
    }
}
