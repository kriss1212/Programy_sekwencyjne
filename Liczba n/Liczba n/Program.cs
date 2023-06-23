using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = int.Parse(Console.ReadLine());

        int liczba = 2; // Rozpoczynamy od pierwszej liczby pierwszej
        int licznik = 0;

        while (licznik < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }
            liczba++;
        }

        Console.ReadKey();
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
        {
            return false; // Liczby mniejsze niż 2 nie są liczbami pierwszymi
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false; // Liczba nie jest pierwsza, gdy jest podzielna przez jakąś liczbę inną niż 1 i sama siebie
            }
        }

        return true; // Liczba jest pierwsza
    }
}
