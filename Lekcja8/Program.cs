namespace Lekcja8;
class Program
{
   static void Main(string[] args)
    {
        // #ToDo: Zadanie1 - Stwórz aplikację fiszki, która pobierze od użytkownika słowo napisane w języku
        // polskim lub angielskim, a następnie wykorzystując instrukcje warunkowe wypisze
        // słowo wraz z tłumaczeniem. Program powinien ignorować wielkość wprowadzonych
        // znaków i działać dla każdej konfiguracji np. “KOT”, “Kot”, “kot” zawsze da “kot”.

        Console.Write("Podaj słowo do przetłumaczenia: ");
        //Kot, kOt, kOT - zmieniamy litery na małe za pomocą ToLower()
        string word = (Console.ReadLine() ?? string.Empty).ToLower();

        switch (word)
        {
            case "kot":
            case "cat":
                Console.WriteLine("kot - cat");
                break;
            default:
                Console.WriteLine("nie znam takiego słowa");
                break;

        }

        int num = 5;
        string result = num.ToString();

        // #ToDo: Zadanie 2 - Napisz program, który pobierze od użytkownika 
        // liczbę i rodzaj operacji do wykonania, a następnie z wykorzystaniem 
        // biblioteki Math dokona obliczeń i wypiszę końcową wartość zaokrągloną 
        // do 2 miejsc po przecinku. Program powinien umożliwić wyliczenie potęgi 
        // ze swojej wartości, pierwiastka i logarytmu.

        // Math - biblioteka
        // Math.Pow()     - potęga - power
        // Math.Sqrt()        - pierwiastek
        // Math.Log()        - logarytm

        // 2^3 = 2 * 2 * 2 (potęga)
        Console.WriteLine("Podaj liczbę ");
        int number = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Podaj wartość:");
        int liczba = int.Parse(Console.ReadLine());
        Console.WriteLine("Wybierz operację: \n1. Potęga \n2. Logarytm \n3. Pierwiastek \n4. Silnia");
        int operacja = int.Parse(Console.ReadLine());
        double wynik = 0;
        switch (operacja)
        {
            case 1:
                wynik = Math.Pow(liczba, liczba);
                break;
            case 2:
                wynik = Math.Log(liczba);
                break;
            case 3:
                wynik = Math.Sqrt(liczba);
                break;
            case 4:
                wynik = Silnia(liczba); // 1*2*3*4*5 = 5!
                break;
            default:
                Console.WriteLine("Nieprawidłowa operacja");
                Console.ReadKey();
                return;
        }
        Console.WriteLine("Wynik = " + Math.Round(wynik, 2));
        Console.ReadKey();
    }

    //własna metoda silnia - jeszcze będziemy się uczyć czym one są :))
    static double Silnia(int liczba)
    {
        double silnia = liczba;
        for (int i = 1; i < liczba; i++)
        {
            silnia *= i;
        }
        return silnia;
    }


}