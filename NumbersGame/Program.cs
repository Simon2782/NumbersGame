namespace NumbersGame //Simon Gustafsson SUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rInt = r.Next(1, 20);
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
        }

        
    }
}
