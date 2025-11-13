namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NullOperations nullOps = new NullOperations();

            Console.WriteLine("Null Operations");
            nullOps.PerformNullChecks();

            Console.WriteLine("Null operation checks executed successfully!");
        }
    }
}
