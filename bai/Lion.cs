using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai
{
    internal class Lion : Animal
    {
        public Lion(int weight, string name)
        {
            SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine($"Lion - Name: {name}, Weight: {weight}");
        }
    }
}
