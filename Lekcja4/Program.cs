namespace Lekcja4;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
            
            // #ToDo: Zadanie 1 - Zegar życia:  
        // Stwórz program konsolowy, który po pobraniu od użytkownika jego wieku, 
        // przeliczy lata na tygodnie, dni, godziny i minuty chodzenia po ziemi. 
        // Przeliczniki: rok ma 52 tygodnie czyli 365 dni; Dzień ma 24 godziny, a godzina 60 minut.

        //Przypominajka: do pobierania innego typu zmiennych niż string, używamy Parsowania

        Console.WriteLine("Podaj swoj wiek: "); 
        int wiek = int.Parse(Console.ReadLine() ?? string.Empty);

        int tygodnie = wiek * 52;
        Console.WriteLine($"To jest {tygodnie} tygodni"); 

        int dni = 365 * wiek;
        int godziny = 24 * dni;
        int minuty = 60 * godziny;

        Console.WriteLine($"Żyjesz już {dni} dni, {godziny} godzin i {minuty} minut");

        long milisekundy = (long) minuty * 60 * 1000;
        Console.WriteLine($"Milisekundy: {milisekundy}");

        long nanosekundy = minuty * (long) 6_000_000_000;
        Console.WriteLine($"Nanosekundy: {nanosekundy}");


        //Logika w programowaniu - operatory logiczne
        Console.WriteLine("ala == kot: " + "ala" == "kot"); //false 
        Console.WriteLine("1==1: " + (1 == 1)); //true 
        //operator przyrównania == 
        //operator przypisania =
        Console.WriteLine("1 != 1: " + (1 != 1)); //false 
        Console.WriteLine("1 > 1: " + (1 > 1)); //false 
        Console.WriteLine("1 < 1: " + (1 < 1)); //false 
        Console.WriteLine("1 >= 1: " + (1 >= 1)); //true 
        Console.WriteLine("1 <= 1: " + (1 <= 1)); // true 

        // bool - true, false - typ logiczny 
        bool wynik = 5>3; //true 
        Console.WriteLine("!wynik to zaprzeczenie: " + !wynik); //!true = false


            // #ToDo: Zadanie 2 - Dowód tożsamości:  
        // Stwórz program który zapyta użytkownika o wiek, a następnie określi czy jest on już pełnoletni. 
        // Skorzystaj z przypisania wartości do zmiennej typu bool.

        Console.WriteLine();
        Console.WriteLine("Ile masz lat: ");
        int age = int.Parse(Console.ReadLine() ?? string.Empty);
        bool czyPelnoletni = age >= 18;
        Console.WriteLine("Czy użytkownik pełnoletni: " + czyPelnoletni);

            // #ToDo: Zadanie 3 - Wejście do kina:  
        // Stwórz program, który zapyta użytkownika o wiek oraz liczbę pieniędzy w portfelu, 
        // a następnie określi na które filmy może wejść do kina.

        // Minionki - od 7 lat, cena 15zł 
        // Harry Potter - od 13 lat, cena 21zł 
        // Avatar - od 16 lat, cena 20zł

        Console.WriteLine("Zadanie z filmami: ");
        Console.WriteLine("Podaj wiek: ");
        int age2 = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Ile masz pieniędzy? ");
        decimal pieniadze = decimal.Parse(Console.ReadLine() ?? string.Empty);

        //przykład z Harrym Potterem
        bool harryPotter = (age2 >= 13 && pieniadze >= 21);
        Console.WriteLine("Czy moze na Harrego Pottera? " + harryPotter);


        //Operator trójargumentowy - daje nam skrótowy zapis w wyrażeniach logicznych, 
        // czyli co w przypadku, gdy wyrażenie jest prawdą, a co gdy jest fałszem
        //forma zapisu:
        //[wyrażenie_logiczne] ? [wykonaj to, gdy prawda] : [wykonaj to, gdy fałsz]
        
        bool czyPeln = true;
        string wynikPeln = czyPeln ? "Tak" : "Nie";
        Console.WriteLine("Czy jesteś pełnoletni? -> " + wynikPeln);


            // Zadanie dodatkowe - System logowania:  
        // Stwórz prosty system logowania do gry, sprawdzający czy 
        // użytkownik podał prawidłowe dane loginu i hasła oraz wyświetlając stosowny komunikat.

            // Zadanie dodatkowe: Stwórz program, który przyjmie od użytkownika długości 3 boków trójkąta 
        // i na podstawie twierdzenia Pitagorasa wyświetli informacje, czy trójkąt jest trójkątem prostokątnym. 
        // Do testów wartości True można użyć prostokątnego trójkąta egipskiego o bokach 3:4:5.


    }
}
