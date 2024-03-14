using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai
{
    internal class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("\nCylinder Characteristics");
            Console.WriteLine($"Radius: {Radius}, Height: {Height}");
            Console.WriteLine($"Base: {BaseArea:F2}");
            Console.WriteLine($"Lateral: {LateralArea:F2} Total: {TotalArea:F2} Volume: {Volume:F2}");
        }
    }
}
