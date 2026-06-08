namespace _03_Medium_Method
{
    internal class Program
    {
        static int AddValues(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Sum: {result}");
            return result;
        }
        static double AddValues(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Sum: {result}");
            return result;
        }
        static int AddValues(int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum:{sum}");
            return sum;
        }
        static void Main(string[] args)
        {
            AddValues(1, 2);
            AddValues(1.2, 3.66);
            int[] myNumbers = { 1,2,3,4,5,6};
            AddValues(myNumbers);
        }
    }
}
