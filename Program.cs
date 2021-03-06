using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mode : ");
            string m = Console.ReadLine();

            if(m == "time")
            {
                Console.Write("Input x : ");
                double t = double.Parse(Console.ReadLine());                                                         
                Console.Write("Input y : ");
                double p = double.Parse(Console.ReadLine());
                if (t < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else
                {
                    p = Math.Pow((t - 1), 2);
                    Console.WriteLine("Output t : " + t);
                    Console.WriteLine("Output p : " + p);
                }
            }
            else if(m == "price")
            {
                Console.Write("Input x : ");
                double t = double.Parse(Console.ReadLine());
                Console.Write("Input y : ");
                double p = double.Parse(Console.ReadLine());
                t = Math.Sqrt(p) + 1;
                Console.WriteLine("Output t : " + t);
                Console.WriteLine("Output p : " + p);
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();

        }
    }
}
