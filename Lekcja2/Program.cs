namespace Lekcja2;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write();
        //Console.ReadKey();
        // Console.Clear();

        //#1 tworzenie zmiennych
        //poznane przez nas typy: 
        string imie = "Adam"; //typ tekstowy
        int wiek = 14; //typ liczb całkowitych 
        int wzrost = 160;
        float waga = 60.90f; //liczby zmiennoprzecinkowe 

        //płeć => plec
        //drugie imie => second_name, secondName


        //#ToDo: Zadanie 1: Stwórz zmienne do przechowywania danych rejestracyjnych do gry. 
        // typ nazwaZmiennej = wartość
        string login = "gracz123";
        //nazwa => string 
        //haslo => string (jak pojawiają się literki), int(kod 4-cyfrowy, 4321)
        //wiek => int 


    
        //#2 Łączenie tekstów i zmiennych - Mam na imię IMIE, mam WIEK lat
        // Console.WriteLine();
        string name = "Adam";
        int age = 20;

        //Sposób 1: KONKATENACJA +
        Console.WriteLine("Mam na imię " + name + ", mam " + age + " lat");

        //Sposób 2: INTERPOLACJA {zmienna} + $
        Console.WriteLine($"Mam na imię {name}, mam {age} lat");

        //Sposób 3: INDEKSOWANIE
        Console.WriteLine("Mam na imię {0}, mam {1} lat", name, age);


        //#ToDo: Zadanie 2: Wypisz na ekranie dane rejestracyjne, 
        // stosując każdy z trzech sposobów wypisywania. 







        //#3 Pobieranie danych różnego typu, czyli PARSOWANIE
        Console.WriteLine("Podaj wiek: ");
        int userAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Podaj wage: ");
        float userWeight = float.Parse(Console.ReadLine());

        Console.WriteLine();


        //#ToDo: Zadanie 3: Pobierz od użytkownika dane rejestracyjne, a następnie wyświetl je na ekranie. 
        //Pobrać od użytkownika 
        // PIN do gry => int  
        // adres e-mail => string
        // i wyświetlić


        //#4 Przepełnienie zmiennych, czyli jak komputer "rezerwuje" miejsce w pamięci
        //To tak, jakbyśmy chcieli zrobić herbatę na płaskim talerzu - wyleje się

        long pesel = long.Parse(Console.ReadLine());

        //#ToDo: Zadanie 4: Pobierz od użytkownika dane: 
        // - płeć (symbol), 
        // - klasę postaci w grze (W - wojownik, M-mag itd.), 
        // - numer karty, 
        // - id gracza.

        // Pobieranie zmiennych typu char: char plec = Console.ReadKey().KeyChar;
        
        // Pobieranie danych od użytkownika
        //char - jeden znak np. K, M
        Console.WriteLine("Podaj płeć (M - mężczyzna, K - kobieta):");
        char plec = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Podaj klasę postaci w grze (W - wojownik, M - mag, L - łucznik, R - rzemieślnik):");
        char klasaPostaci = Console.ReadKey().KeyChar;
        Console.WriteLine();

        //long - więecej miejsca w pamięci niż int 
        Console.WriteLine("Podaj numer karty (np. 1234567812345678):");
        long numerKarty = long.Parse(Console.ReadLine());

        Console.WriteLine("Podaj ID gracza:");
        long idGracza = long.Parse(Console.ReadLine());

        // Wyświetlenie wszystkich danych
        Console.WriteLine("\n🎮 Dane gracza:");
        Console.WriteLine("Płeć: {0}", plec);
        Console.WriteLine("Klasa postaci: {0}", klasaPostaci);
        Console.WriteLine("Numer karty: {0}", numerKarty);
        Console.WriteLine("ID gracza: {0}", idGracza);

    }
}
