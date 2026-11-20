namespace Lekcja9;

class Program
{
    static void Main(string[] args)
    {
        // kroki tworzenia nowego projektu:
        // Musimy mieć otwarty folder gigantowy z projektami z zajęć
        // Terminal -> New Terminal
        // dotnet new console -n Lekcja9 --use-program-main
        // wejście do katalogu: cd Lekcja9
        // uruchomienie projektu: dotnet run


        //#ToDo: Zadanie 1 - Stwórz program, który poprosi o hasło,
        // sprawdzi jego poprawność i wyświetli “Zalogowano” lub “Złe hasło, spróbuj ponownie"
        // skorzystaj z instrukcji warunkowej if

        // Wersja 1: z instrukcją if - sprawdzamy hasło tylko RAZ.
        // Nawiasy klamrowe { } tworzą osobny blok - zmienne ze środka "żyją" tylko w nim,
        // dzięki temu w wersji 2 możemy użyć tych samych nazw zmiennych.
        {
            string password = "tajne haslo";           // poprawne hasło zapisane w programie
            Console.WriteLine("Podaj hasło: ");
            string userPassword = Console.ReadLine() ?? string.Empty; // ?? string.Empty - gdyby ReadLine zwróciło null, bierzemy pusty tekst

            if (password == userPassword)               // == porównuje, czy teksty są takie same
                Console.WriteLine("Zalogowano!");
            else
                Console.WriteLine("Niepoprawne hasło");
        }


        //Składnia pętli while:

        // while (warunek) {}
        // Pętla while powtarza kod w { } TAK DŁUGO, JAK warunek jest prawdziwy (true).

        // Wersja 2: z pętlą while - pytamy o hasło, dopóki użytkownik nie poda dobrego.
        {
            string password = "tajne haslo";
            Console.WriteLine("Podaj hasło: ");
            string userPassword = Console.ReadLine() ?? string.Empty;

            while (password != userPassword)            // != oznacza "różne od" - kręcimy się, dopóki hasło jest złe
            {
                Console.WriteLine("Złe hasło, spróbuj ponownie");
                Console.WriteLine("Podaj hasło: ");
                userPassword = Console.ReadLine() ?? string.Empty; // pytamy jeszcze raz - bez tego pętla nigdy by się nie skończyła!
            }
            Console.WriteLine("Zalogowano");            // tu dochodzimy dopiero po podaniu dobrego hasła
        }

        //#ToDo: Zadanie 2 - Stwórz program, który umieści gracza na pozycji 0,
        // a następnie będzie go przesuwał o losowe kroki (1-6).
        // Program powinien się zatrzymać, kiedy gracz dojdzie do pozycji 32.
        // - pozycję przechowuj w zmiennej odpowiedniego typu
        // - skorzystaj z klasy Random - Random r = new Random();
        // - losowanie kolejnej liczby z danego zakresu - r.Next(1,7);

        // Zadanie dodatkowe: Zmodyfikuj program tak, aby był dla dwóch graczy. Gra się kończy, gdy jeden z graczy dojdzie do mety.

        int pozycja = 0;                // int - liczba całkowita, gracz startuje z pola 0
        Random r = new Random();        // obiekt do losowania liczb

        while (pozycja < 32 )           // gramy, dopóki gracz nie dojdzie do mety (pole 32)
        {
            int rzut = r.Next(1,7);     // losuje liczbę od 1 do 6 (górna granica 7 NIE jest wliczana)
            // pozycja = pozycja + rzut;
            pozycja += rzut;            // += to skrót od: pozycja = pozycja + rzut

        }

        Console.WriteLine("Doszedłeś do mety");



        // Składnia pętli for:
        // for (start; warunek; krok) - wszystko, czego potrzebuje licznik, jest w jednej linijce

        for (int i = 5; i<100; i++)     // od 5 do 99, co 1 (i++ to i = i + 1)
        {
            Console.WriteLine(i);
        }


        for (int i = 5; i<100; i += 5)  // od 5 do 95, co 5
        {
            Console.WriteLine(i);
        }


        for (int i = 50; i>0; i--)      // odliczanie w dół: od 50 do 1 (i-- to i = i - 1)
        {
            Console.WriteLine(i);
        }

        //#ToDO: Zadanie 3 - Stwórz program, który zapyta użytkownika o dowolną liczbę,
        // a następnie wyświetli wszystkie liczby parzyste mniejsze od tej liczby, zaczynając od 2.
        // Zadanie dodatkowe: Zmodyfikuj program tak, aby wyświetlał wszystkie wielokrotności liczby 17 mniejsze od podanej.
        // wielokrotności 17 to liczby: 17, 17+17, 17+17+17, ...

        // parzyste -> i+=2

        Console.WriteLine("Daj liczbe: ");
        int liczba = int.Parse(Console.ReadLine() ?? "0"); // int.Parse zamienia tekst na liczbę

        for (int i = 2; i < liczba ; i += 2)  // zaczynamy od 2 i skaczemy co 2 -> same liczby parzyste
        {
            Console.Write(i + " ");     // Write nie robi nowej linii, więc dodajemy spację, żeby liczby się nie sklejały
        }
        Console.WriteLine();            // przejście do nowej linii po wypisaniu wszystkich liczb

        //Klauzule break i continue:
        // break    - natychmiast KOŃCZY całą pętlę
        // continue - pomija resztę TEGO obrotu pętli i przechodzi do następnego

        while(true)                     // while(true) - pętla "nieskończona", wyjść z niej można tylko przez break
        {
            Console.Write("Podaj wiadomość: ");
            string msg = Console.ReadLine() ?? string.Empty;

            if(msg == "koniec")
                break;                  // wpisanie "koniec" kończy pętlę

            Console.WriteLine($"Wiadomość: {msg}"); // $"..." pozwala wstawić zmienną do tekstu w { }
        }


        // UWAGA: ta pętla nie ma break, więc nigdy się nie skończy!
        // "koniec" tylko pomija wyświetlenie wiadomości. Program zatrzymujemy skrótem Ctrl + C.
        while(true)
        {
            Console.Write("Podaj wiadomość: ");
            string msg = Console.ReadLine() ?? string.Empty;

            if(msg == "koniec")
                continue;               // wraca na początek pętli - linijka niżej się NIE wykona

            Console.WriteLine($"Wiadomość: {msg}");
        }


        //#ToDo: Zadanie 4 - Napisz program, który wyświetla wyniki dzielenia liczby 12
        // przez 4 liczby podane przez użytkownika. Pomiń liczby 1 i 12. W przypadku 0 - przerwij pętlę.
        // Podpowiedź: pętla for (4 powtórzenia) + continue dla 1 i 12 + break dla 0

        //#Zadanie dodatkowe - Zapisz w zmiennej liczbę. Pozwól graczowi zgadywać, dopóki nie odgadnie
        //#Zadanie dodatkowe - Zapytaj użytkownika o liczbę. Wyświetl 4 kolejne wielokrotności tej liczby
    }
}