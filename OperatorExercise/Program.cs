using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} with a remainder of {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            string userInput = Console.ReadLine(); 

            double radius = double.Parse(userInput);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}.");

        }


        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
      
    }
}
