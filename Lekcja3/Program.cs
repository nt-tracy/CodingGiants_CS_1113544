namespace Lekcja3;

class Program
{
    static void Main(string[] args)
    {
        //Przypomnienie tworzenia zmiennych
        //typ nazwaZmiennej = wartość;

        //Wczytywanie floata (liczba z przecinkiem)
        float liczba1 = 3.6f;
        float liczba2 = float.Parse(Console.ReadLine()); //wczytujemy z klawiatury z przecinkiem
        Console.WriteLine(liczba1 + " " + liczba2);

        //Poznane przez nas typy zmiennych:
        // string - typ tekstowy
        // int - typ liczb całkowitych
        // long - typ liczb całkowitych, większy niż int
        // float - typ liczb zmiennoprzecinkowych, np 6,70 (f)
        // double - typ liczb zmiennoprzecinkowych, większy od floata
        // char - typ znakowy - (wczytywanie z konsoli - Console.ReadKey().KeyChar)
       
        Console.WriteLine("Podaj tekst i liczbę? ");
        string text = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Podano tekst {text}, oraz liczbę {num}"); 

        //#ToDo: Zadanie 1: Napisz program, który zapyta użytkownika o:
        // - imię - string
        // - ulubioną rzecz do robienia w wolnym czasie - string
        // - ilość godzin wolnego czasu - int
        // a następnie wypisze komunikat: „{imie}, masz dziś {ile_godzin} godziny wolnego. Możesz {zajecie}, albo obejrzeć film.”
        
        // Wykonanie: napisz zapytanie o każdą rzecz, przechwyć odpowiedź z terminala do zmiennej odpowiedniego typu, 
        // a następnie wypisz komunikat, zawierający te zmienne, jednym z ostatnio poznanych sposobów (konkatenacja, interpolacja, indeksowanie)

        //Przykładowe rozwiązanie:
        Console.WriteLine("Podaj swoje imie:");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Podaj ulubioną rzecz do robienia w wolnym czasie:");
        string fav = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Podaj swoje imie:");
        int freeTime = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine($"{name}, masz dziś {freeTime}h wolnego. Możesz {fav}, albo obejrzeć film.");

        // Działania matematyczne na zmiennych
        int a = 1;
        int b = 2;

        // dodawanie
        int suma = a+b; 

        // odejmowanie
        int roznica = a-b;

        // dzielenie 
        float iloraz = a/b;

        // mnozenie
        int iloczyn = a*b;

        int wynik = 1 + 2*3 - (a*b) + 4;
        Console.WriteLine(wynik);

        //#ToDo: Zadanie 2 - Napisz program, który zapyta użytkownika o 
        // trzy ostanie oceny z przedmiotu, a następnie obliczy ich średnią arytmetyczną i wypisze na ekran
        // (podpowiedź: podziel przez 3f)

        Console.WriteLine("Ocena 1: ");
        int ocena1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ocena 2: ");
        int ocena2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ocena 3: ");
        int ocena3 = int.Parse(Console.ReadLine());

        int sumaOcen = ocena1 + ocena2 + ocena3;
        double srednia = sumaOcen / 3f;

        Console.WriteLine("Srednia ocen to: " + srednia);


        // utrata precyzji i rzutowanie
        int x = 5;
        int y = 2;

        Console.WriteLine(x/y); //dzielenie "/" - DZIELENIE CALKOWITE
        // Console.WriteLine(float.Parse(a/b)); //Błąd!
        Console.WriteLine((float) x/y );



        //#ToDo: Zadanie 3 -  Jeden z uczniów ma urodziny przyniósł do szkoły cukierki. 
        // Oblicz ile cukierków przypada na danego ucznia, 
        // jeżeli w klasie jest obecnych są 23 osoby, a cukierków 60. 

        // Wylicz wartość zmiennej naUcznia - ile całych cukierków przypada na jednego ucznia, dzielenie całkowite
        // oraz wylicz wartość zmiennej naUczniaDokladnie - dzielenie dokładne, z przecinkiem, użyj rzutowania na float

        int cukierki = 60;
        int osoby = 23;

        int naUcznia = cukierki / osoby;
        Console.WriteLine("Na ucznia przypada " + naUcznia + " cukierków");

        float dokladnieNaUcznia = (float)cukierki / osoby;
        Console.WriteLine("Dokładnie na ucznia przypada " + dokladnieNaUcznia + " cukierków");

        


        //MODULO - % - reszta z dzielenia
        // 4 % 2 -> 0 
        // 20 % 4  -> 0
        // 5 % 2 -> 1
        // 21 % 8 -> 5

        //#ToDo: Zadanie 4 - Kontynuuj poprzedni pogram i oblicz ile cukierków zostało nierozdanych, 
        // którymi można poczęstować nauczycieli (oblicz resztę z dzielenia za pomocą operacji modulo)

        int resztaCukierkow = cukierki % osoby;
        Console.WriteLine(resztaCukierkow);

        //Klasa Math - przydatne funkcje do wykonywania bardziej złożonych działań matematycznych :)
        //Pow - power
        double potega = Math.Pow(2, 3);  // 2^3 = 8
        Console.WriteLine(potega);



        //Zadanie dodatkowe 0: Moc komputerów: Oblicz, jak wiele razy szybszy będzie komputer 
        // po określonej liczbie lat. Załóż, że jeśli co rok wychodzi nowy model komputera i
        // jest on 2 razy szybszy od poprzedniego, 
        // to po 5 latach komputer będzie około 32 razy szybszy niż na początku!

        //Schemat zadania:
        //pierwsza zmienna - przyrost
        //druga zmienne - lata
        //trzecia zmienna - wynik (obliczenie wzrostu mocy komputera)
        //wypisz komunikat


        //Zadanie dodatkowe 1: W szkolnej pracowni uczniowie drukują swoje projekty na drukarce 3D. 
        // Każdy wydruk zajmuje pewien czas w minutach. Nauczyciel chce wiedzieć: 
        // ile pełnych godzin zajmie wydruk wszystkich projektów (Math.Ceiling),  
        // oraz o ile minut dłużej trwa druk niż planowano (Math.Abs).


        //Zadanie dodatkowe 2:
        // Napisz program obliczający pole trapezu z wartości podanych przez użytkownika.  


        //Zadanie dodatkowe 3:
        // Napisz program obliczający pole koła. Użyj do tego metod i stałych z klasy Math. 
        // (stała, o której mowa to Math.PI z klasy Math)


        //Zadanie dodatkowe 4:
        // Napisz program obliczający objętość kuli z wykorzystaniem klasy Math, 
        // gdzie promień kuli zostanie pobrany od użytkownika  z konsoli.


    }
}
