namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();

            op.Add(7, 8);
            op.Subtract(19, 10);
            op.Multiply(5, 6);
            op.Divide(12, 3);
            op.OddEvenFinder(7);
            op.OddEvenFinder(52);
        }
    }
}
