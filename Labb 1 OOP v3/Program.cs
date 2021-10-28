using System;

namespace Labb_1_OOP_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle U1 = new Circle(5);  // First Circle with radius 5
            U1.output();
            
            Console.WriteLine("");
            
            Circle U2 = new Circle(6); // Second Circle with radius 6
            U2.output();
            
            
            
            
            Console.ReadKey();
        }
    }



    class Circle
    {
        // Fields
        private double radius;

        // Constructor with parameter
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Method to calculate area of circle
        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);  
        }
        // Method to type out the answer to console. Uses getArea method to get the answer. 
        public void output()
        {
            Console.WriteLine("Arean på cirkeln är = " + this.getArea());
        }
    }
} 
