﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Lion Details:");
            base.Show();
        }
    }
}