namespace Lekcja6;

class Program
{
    static void Main(string[] args)
    {
        //#ToDO: Zadanie 1: (Przypomnienie)
        // Stwórz program, który zapyta użytkownika o hasło, a następnie sprawdzi i wyświetli, czy hasło jest poprawne.
        // Podpowiedź: Korzystamy tutaj z zmiennej typu bool i operatora porównania ==. Wartość zmiennej bool może być true lub false.

        //Przykładowe rozwiązanie:
        //1. Zapisz jakieś hasło w zmiennej. (np. string haslo = "tajnehaslo";)
        //2. Zapytaj użytkownika o hasło i zapisz je w zmiennej.
        //3. Sprawdź, czy hasło podane przez użytkownika jest takie samo jak zapisane w zmiennej.
        //4. Wyświetl odpowiedni komunikat czy hasło jest poprawne czy nie, np. (Poprawność hasła: "true/false")

        string password = "tajnehaslo";
        Console.WriteLine("Podaj haslo: ");
        string userInput = Console.ReadLine() ?? string.Empty;
        bool correct = password == userInput;
        Console.WriteLine($"Hasło {userInput} jest {correct}");


        if (correct) //if(password == userInput)
        {
            Console.WriteLine("Hasło jest poprawne");
        }
        else
        {
            Console.WriteLine("Hasło niepoprawne");
        }


        // if ( number > 5)
        // {

        // } else
        // {

        // }


        //#ToDO: Zadanie 2: (Instrukcja warunkowa)
        // Stwórz program, który zapyta użytkownika o średnią ocen i wyświetli, czy należy się czerwony pasek.
        // Dodatkowe*: Spróbuj podczas przyznawania czerwonego paska uwzględnić także zachowanie.

        Console.WriteLine("Podaj 1 Ocene: ");
        int Ocena1 = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Podaj 2 Ocene: ");
        int Ocena2 = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Podaj 3 Ocene: ");
        int Ocena3 = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Podaj Ocene z zachowania: ");
        int Zachowanie = int.Parse(Console.ReadLine() ?? string.Empty);


        double Srednia = (Ocena1 + Ocena2 + Ocena3) / 3.0;
        Console.WriteLine($"{Srednia}");

        if (Srednia >= 4.75)
        {
            if (Zachowanie >= 4)
            {
                Console.WriteLine("Masz PASEK!!!!!!");
            }
            else
            {
                Console.WriteLine("NIE MASZ PASKU HAHAHAHHAHAH!");
            }
        }
        else
        {
            Console.WriteLine("NIE MASZ PASKU HAHAHAHHAHAH!");
        }

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("System operacyjny TempleeOS jest najciekawszym systemem");
        } else if (choice == 2)
        {
            Console.WriteLine("System operacyjny Linux jest najciekawszym systemem");
        } else if (choice == 3)
        {
            Console.WriteLine("System operacyjny Windows jest najciekawszym systemem");
        } else
        {
            Console.WriteLine("Nie ma takiego systemu");
        }

        //#ToDO: Zadanie 3: (Else if)
        //Stwórz program, który zapyta użytkownika o numer dnia tygodnia i wyświetli jego pełną nazwę.
        //Np. 1 - Poniedziałek, 2 - Wtorek, 3 - Środa, 4 - Czwartek, 5 - Piątek, 6 - Sobota, 7 - Niedziela



        //Losowanie liczb
        Random random = new Random(); 
        Console.WriteLine(random.Next(100));
        Console.WriteLine(random.Next(50, 100));

        //String, a wartości logiczne: 
        string napis = "Testowe zdanie";
        Console.WriteLine("Długość tekstu  " + napis.Length); //długość tekstu
        Console.WriteLine("Czy coś zawiera: " + napis.Contains("zdanie")); //sprawdzanie czy zawiera dany tekst



        //#ToDO: Zadanie 4: (String, a wartości logiczne)
        //Stwórz program, który na podstawie podanego przez użytkownika hasła stwierdzi, 
        // czy hasło jest silne i jakie spełnia standardy bezpieczeństwa.

        //Podpowiedź: Hasło jest silne, jeśli spełnia przykładowe następujące warunki:
        // - ma co najmniej 8 znaków    
        // - zawiera jakiś znak specjalny (np. !, @, #, $, %)
        // - zawiera jakąś cyfrę (0-9)







        //Zadania dodatkowe:

        //#ToDo: Zadanie dodatkowe 1: Liczby parzyste
        // Stwórz program, który sprawdzi czy podana liczba jest parzysta.

        //#ToDo: Zadanie dodatkowe 2: Kalkulator:
        // Stwórz program, który zapyta użytkownika o dwie liczby i znak, 
        // a następnie wykona odpowiednie działanie matematyczne w zależności od podanego znaku.
        // Dodatkowo spróbuj zabezpieczyć program przed dzieleniem przez zero.

    }
}
