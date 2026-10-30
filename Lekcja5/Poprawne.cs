// PROGRAM DO NAPRAWY – znajdź i popraw wszystkie błędy!
class Poprawne
{
    public static void Start()
    {
        Console.WriteLine("Witaj w kinie!"); // 1) zła wielkość liter + brak średnika

        Console.WriteLine("Jak masz na imię?"); // 2) brak zamykającego cudzysłowu
        string name = Console.ReadLine() ?? string.Empty;      // 3) brak średnika

        int age = 12; // 4) zły typ przypisania: tekst do liczby

        bool hasTicket;
        Console.WriteLine("Czy masz bilet? (tak/nie)");
        string answer = Console.ReadLine() ?? string.Empty;
        hasTicket = answer == "tak";           // 5) brak średnika

        if (age >= 13 && hasTicket == true)    // 6) użyto = zamiast == i brakuje nawiasu )
        {
            Console.WriteLine($"Zapraszamy, {name}!"); // 7) tu jest OK
        }
        else
        {
            Console.WriteLine("Niestety, film od 13 lat");
        } // 8) zbędny nawias i brakuje zamykającej klamry gdzie indziej


        Console.WriteLine("Do zobaczenia, " + name); // 9) podwójny średnik


        Console.WriteLine("Do zobaczenia, " + name); ;
    }
}