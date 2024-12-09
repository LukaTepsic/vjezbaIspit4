using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite neku rečenicu:");
        string rečenica = Console.ReadLine();

        string[] riječi = rečenica.Split(' ');

        if (riječi.Length > 0)
        {
            string prvaRiječ = riječi[0];
            string zadnjaRiječ = riječi[riječi.Length - 1];

            Console.WriteLine($"Prva riječ: {prvaRiječ}");
            Console.WriteLine($"Zadnja riječ: {zadnjaRiječ}");
        }
        else
        {
            Console.WriteLine("Niste unijeli rečenicu.");
            Console.ReadKey();
        }
    }
}
