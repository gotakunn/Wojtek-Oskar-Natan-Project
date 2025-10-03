using ConsoleApp1;
using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Ustawienie koloru tekstu
Console.ForegroundColor = ConsoleColor.Cyan;

// ASCII Art
Console.WriteLine("########################################");
Console.WriteLine("#                                      #");
Console.WriteLine("#                                      #");
Console.WriteLine("#  __        __     ___        _   _   #");
Console.WriteLine("#  \\ \\      / /    / _ \\      | \\ | |  #");
Console.WriteLine("#   \\ \\ /\\ / /____| | | |_____|  \\| |  #");
Console.WriteLine("#    \\ V  V /_____| |_| |_____| |\\  |  #");
Console.WriteLine("#     \\_/\\_/       \\___/      |_| \\_|  #");
Console.WriteLine("#                                      #");
Console.WriteLine("#                                      #");
Console.WriteLine("########################################");

// Reset koloru
Console.ResetColor();

Thread.Sleep(2000);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Wybierz opcję z menu:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1. NWD");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("2. BoobleSort");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3. Szyfr Cezara");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("4. Czy Palinindrom");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("5. Zamknij");

Console.ResetColor();

Console.Write("\nTwój wybór: ");
string wybor = Console.ReadLine();

Console.WriteLine(); // Pusta linia

// Obsługa wyboru z kolorem
switch (wybor)
{
    case "1":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Obliczanie NWD...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Podaj dwie liczby całkowite, aby obliczyć NWD:");
        int a, b;
        while (true)
        {
            Console.Write("Liczba 1: ");
            if (int.TryParse(Console.ReadLine(), out a))
                break;
            Console.WriteLine("Nieprawidłowa liczba. Spróbuj ponownie.");
        }
        while (true)
        {
            Console.Write("Liczba 2: ");
            if (int.TryParse(Console.ReadLine(), out b))
                break;
            Console.WriteLine("Nieprawidłowa liczba. Spróbuj ponownie.");
        }
        int nwd = Matematyczna.NWD(a, b);
        Console.WriteLine($"NWD({a}, {b}) = {nwd}");

        Thread.Sleep(1000);
        break;
    case "2":
        Console.ForegroundColor = ConsoleColor.Blue;
        // BoobleSort example
        Console.WriteLine("Obliczanie Booble Sort...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Podaj liczby całkowite oddzielone spacjami, aby posortować je za pomocą Booble Sort:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = Array.ConvertAll(parts, int.Parse);
        Matematyczna math = new Matematyczna();
        int[] sorted = math.BoobleSort(numbers);
        Console.WriteLine("Posortowane liczby: " + string.Join(", ", sorted));

        Thread.Sleep(1000);
        break;
    case "3":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Szyfr Cezara...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("Podaj tekst do zaszyfrowania: ");
        string tekst = "";
        tekst = Console.ReadLine();
        Console.Write("Podaj przesunięcie (liczba całkowita): ");
        int przesuniecie;
        while (!int.TryParse(Console.ReadLine(), out przesuniecie))
        {
            Console.Write("Nieprawidłowa liczba. Podaj przesunięcie (liczba całkowita): ");
        }
        Tekstowo tekstowo = new Tekstowo();
        string zaszyfrowany = tekstowo.SzyfrCezara(tekst, przesuniecie);
        Console.WriteLine($"Zaszyfrowany tekst: {zaszyfrowany}");

        Thread.Sleep(1000);
        break;
    case "4":
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Sprawdzanie palindromu...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("Podaj tekst do sprawdzenia: ");
        string tekstPalindrom = "";
        tekstPalindrom = Console.ReadLine();
        Tekstowo tekstowoPalindrom = new Tekstowo();
        bool isPalindrom = tekstowoPalindrom.CzyPalindrom(tekstPalindrom);
        Console.WriteLine(isPalindrom ? "To jest palindrom." : "To nie jest palindrom.");
        Thread.Sleep(1000);

        break;
    case "5":
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Zamykanie programu...");
        Thread.Sleep(1000);
        Environment.Exit(0); // 0 oznacza poprawne zakończenie
        break;
    default:
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Nieprawidłowy wybór.");
        break;
}

Console.ResetColor();
Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć.");
Console.ReadKey();
