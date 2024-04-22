namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fruits = new List<string>();
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Apple");



            Console.WriteLine("Before : ");

            foreach (var fruit in fruits)
                Console.WriteLine($"\t{fruit}");

            fruits.RemoveAt(0);

            fruits.Remove("Apple");

            fruits[0] = "Strawberry";

            Console.WriteLine("-----------------------");


            Console.WriteLine("After : ");


            foreach (var fruit in fruits)
                Console.WriteLine($"\t{fruit}");
        }
    }
}
