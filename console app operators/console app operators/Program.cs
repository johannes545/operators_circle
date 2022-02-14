using System;

namespace console_app_operators
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num1 = 17;
            int num2 = 4;

            int answer = num1 %= num2;

            Console.WriteLine(answer);


            double pi = 3.14;
            Console.WriteLine("what is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"the area of a circle with the radius of 20 is { (AreaOfCircle(pi, radius))}");
            
           
        }


        public static double AreaOfCircle(double pi, double radius)
        {

            return (pi * radius * radius);
         
        }


    }
}
