namespace Lekcja5;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Podaj imie: ");
        string imie = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Witaj " + imie + "!");
        Console.WriteLine("Jak się dzisiaj czujesz? ");
        int samopoczucie = int.Parse(Console.ReadLine() ?? string.Empty);

        bool czyDobrze = samopoczucie > 5; //true false 
        string komunikat = czyDobrze ? "Cieszę się, że dobrze się czujesz!" : "Przykro mi, że nie czujesz się najlepiej.";
        Console.WriteLine(komunikat);
        Console.ReadKey();

        // #ToDo: Zadanie 1 - Średnia końcowa:  
        // Stwórz program, który pobierze od użytkownika oceny semestralne z trzech przedmiotów,
        // a następnie policzy ich średnią końcową i oszacuje, czy jest ona wystarczająca do uzyskania stypednium. 

        //Przykładowe rozwiązanie:
        Console.WriteLine("Podaj oceny z matematyki, fizyki i informatyki oddzielone enterem");
        int ocenaMatma = int.Parse(Console.ReadLine() ?? string.Empty);
        int ocenaFizyka = int.Parse(Console.ReadLine() ?? string.Empty);
        int ocenaInfa = int.Parse(Console.ReadLine() ?? string.Empty);


        Console.WriteLine("Podaj procentową frekwencję na zajęciach szkolnych");
        int frekwencja = int.Parse(Console.ReadLine() ?? string.Empty);


        float srednia = (float)(ocenaMatma + ocenaFizyka + ocenaInfa) / 3;
        bool czyStypendium = (srednia > 4.75 && frekwencja >= 85);
        string wynik = czyStypendium ? "Tak, gratulacje!" : "Nie, postaraj się bardziej";


        Console.WriteLine("Czy dostaniesz stypendium? " + wynik);
        Console.ReadKey();

        // Zadanie 2 - Naprawa błędów:  
        // Popraw błędy w pliku Bledy.cs tak, aby dało się skompilować napisany w nim program. 
        // Wspomóż się komunikatami widocznymi w zakładce Problems, Notatnikiem błędów oraz Sztuczną Inteligencją. 
        
        //Uruchamianie pliku Bledy.cs z poziomu Program.cs
        // Bledy.Start();

        // Uruchamianie pliku Poprawne.cs z poziomu Program.cs
        Poprawne.Start();
    }
}
