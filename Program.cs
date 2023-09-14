namespace Spelet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hemligt = 7;

            while (true)
            {
                Console.WriteLine("Gissa talet");
                int input = int.Parse(Console.ReadLine());

                if (input == hemligt)
                {
                    Console.WriteLine("Du har gissat rätt");
                    break;
                }
                else if (input == hemligt + 1 || input == hemligt - 1)
                {
                    Console.WriteLine("Du var nära");
                }
                else if (input > hemligt)
                {
                    Console.WriteLine("Talet är för högt");
                }
                else if (input < hemligt)
                {
                    Console.WriteLine("Talet är för lågt");
                }
            }
            Console.WriteLine("Spelet är slut");
            
        }
    }
}