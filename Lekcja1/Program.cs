namespace Lekcja1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //komentarz jednolinijkowy

        /*
        
        komentarz wielolinijkowy
        
        */

        // Python -> #
        // SQL -> --

        Console.WriteLine("Cześć nazywam się GigaCzat, jak masz na imię? ");
        string odpowiedz = Console.ReadLine();
        Console.WriteLine("Witaj " + odpowiedz);




        string onomatopeja = "klik";
        string pozytywne = "";
        string synonim = "";

        Console.WriteLine("💻 Twój wierszyk o programowaniu:");
        Console.WriteLine("--------------------------------");
        
        // Rymowanka
        Console.WriteLine("Piszę kodzik cały dzień,");
        Console.WriteLine("w moim IDE słychać " + onomatopeja + ".");
        Console.WriteLine("Gdy program działa, " + pozytywne + " mam,");
        Console.WriteLine("a gdy nie działa — " + synonim + " sam!");
        
    }
}
