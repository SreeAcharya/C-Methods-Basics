namespace _03_Medium_Methodd
{
    internal class Program
    {
        static void Search(string keyword)
        {
            Console.WriteLine($"Word: {keyword}");
        }

        static void Search(string keyword, int lim = 10, bool sortByDate = true)
        {
            Console.WriteLine($"Word: {keyword}, limit: {lim}, Sort by date: {sortByDate}");

        }
        static void Search(int CategoryId, int limit = 10)
        {
            Console.WriteLine($"ID: {CategoryId}");

        }
        static void Main(string[] args)
        {
            Search("c#");
        }
    }
}
