using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Philippine Bank Note Scanner!");
        Console.WriteLine("Please enter the denomination (in PHP):");

        if (double.TryParse(Console.ReadLine(), out double denomination))
        {
            string personality = banknotepersonality(denomination);
            if (personality != null)
                Console.WriteLine($"Personality found on {denomination} PHP: {personality}");
            else
                Console.WriteLine("No person is found on the banknote.");
        }
        else
        {
            Console.WriteLine("Invalid Denomination");
        }
    }

    static string banknotepersonality(double denomination)
    {
        switch (denomination)
        {
            case 1: return "Jose Rizal";
            case 5: return "Emilio Aguinaldo";
            case 10: return "Andres Bonifacio, Apolinario Mabini";
            case 20: return "Manuel L. Quezon";
            case 50: return "Sergio Osmena";
            case 100: return "Manuel Roxas";
            case 200: return "Diosdado Macapagal";
            case 500: return "Benigno Sr. and Corazon Aquino";
            case 1000: return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            default: return null;
        }
    }
}
