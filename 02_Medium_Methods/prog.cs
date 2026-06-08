namespace _02_Medium
{
    internal class Program
    {
        static void BuildProfile(string firstName, string lastName, string City, string Country)
        {
            Console.WriteLine($"Firstname:{firstName} | Lastmame:{lastName} | City:{City} | Country:{Country}");
        }
        static void Main(string[] args)
        {
            BuildProfile("Sree","Acharya", "KualaLumpur", "Singapore");
        }
    }
}
