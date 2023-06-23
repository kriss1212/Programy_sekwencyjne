using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = int.Parse(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadKey();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = 2 * wysokosc - 1;
        int spacje = szerokosc / 2;
        int plusy = 1;

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < plusy; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();

            spacje--;
            plusy += 2;
        }
    }
}