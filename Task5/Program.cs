using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop loops = new Loop();

            Console.WriteLine("Loop");
            loops.SumFrom1ToN();
            loops.WhileLoop();
            loops.ArraySum();

            Console.WriteLine("loop examples executed successfully!");
        }
    }
}
