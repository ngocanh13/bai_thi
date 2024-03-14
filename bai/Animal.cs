﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai
{
    internal class Animal
    {
        protected int weight;
        protected string name;

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Animal - Name: {name}, Weight: {weight}");
        }
    }
}
