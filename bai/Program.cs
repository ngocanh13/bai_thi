using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1: GeometryExample");
            Console.WriteLine("Enter the dimensions of the cylinder:");

            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();
            cylinder.Result();

            Console.WriteLine();

            Console.WriteLine("Exercise 2: Inheritance and Polymorphism");

            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");

            lion.Show();
            tiger.Show();
        }
    }
}
