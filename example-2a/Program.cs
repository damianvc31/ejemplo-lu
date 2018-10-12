using System;
using System.Collections.Generic;
using Classes;

namespace example_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            var formas = new List<Shape>();
            formas.Add(new Circle(5));
            formas.Add(new Triangle(10,20));
            formas.Add(new Rectangle(6,7));
            formas.Add(new Square(9));

            foreach(Shape item in formas){
                Console.WriteLine($"Area de la forma es: {item.Area()}");
            }
        }
    }
}
