using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai
{
    internal class Tiger : Animal
    {
        public Tiger(int weight, string name)
        {
            SetMe(weight, name);
        }

        public override void Show()
        {
            Console.WriteLine($"Tiger - Name: {name}, Weight: {weight}");
        }
    }
}
