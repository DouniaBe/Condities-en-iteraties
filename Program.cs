// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        Console.WriteLine("Omgekeerde applicatie");

        // Vraag de gebruiker om tekst in te voeren.
        Console.Write("Voer een tekst in om deze om te keren: ");
        string Tekstgebruiker = Console.ReadLine();

        // Laat de gebruiker kiezen tussen de iteratiemethoden (menu).
        Console.WriteLine("Kies een iteratiemethode:");
        Console.WriteLine("1: for-loop");
        Console.WriteLine("2: while-loop");
        Console.WriteLine("3: do-while-loop");
        Console.WriteLine("4: recursie");

        // Lees de keuze van de gebruiker.
        int Keuze;

        if (!int.TryParse(Console.ReadLine(), out Keuze))
        {
            Console.WriteLine("Ongeldige invoer. Voer een geldig nummer in.");
            return;
        }

        switch (Keuze)
        {
            case 1:
                ReverseWithForLoop(Tekstgebruiker);
                break;
            case 2:
                ReverseWithWhileLoop(Tekstgebruiker);
                break;
            case 3:
                ReverseDoWhileLoop(Tekstgebruiker);
                break;
            case 4:
                Console.WriteLine(ReverseWithRecursion(Tekstgebruiker));
                break;
            default:
                Console.WriteLine("Ongeldige keuze");
                break;
        }
    }

    // Methode om een string om te keren met behulp van een for-loop.
    static void ReverseWithForLoop(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }

    // Methode om een string om te keren met behulp van een while-loop.
    static void ReverseWithWhileLoop(string text)
    {
        int i = text.Length - 1;
        while (i >= 0)
        {
            Console.Write(text[i]);
            i--;
        }
        Console.WriteLine();
    }

    // Methode om een string om te keren met behulp van een do-while-loop.
    static void ReverseDoWhileLoop(string text)
    {
        int i = text.Length - 1;
        do
        {
            Console.Write(text[i]);
            i--;
        } while (i >= 0);
        Console.WriteLine();
    }

    // Methode om een string om te keren met behulp van recursie.
    static string ReverseWithRecursion(string text)
    {
        if (text.Length == 0)
        {
            return "";
        }
        else
        {
            return text[text.Length - 1] + ReverseWithRecursion(text.Substring(0, text.Length - 1));
        }
    }
}
