using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        protected string name;
        protected double weight;

        public Animal()
        {
            name = "Unknown";
            weight = 0.0;
        }

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name},Weight: {weight} kg ");
            
        }
    }
}
