
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // liczba liczb do wylosowania
        int count = 0; // licznik losowań

        Random random = new Random();
        List<int> evenNumbers = new List<int>();

        while (evenNumbers.Count < n)
        {
            int randomNumber = random.Next(-4, 5) * 2;

            evenNumbers.Add(randomNumber);
            count++;
        }

        Console.WriteLine("Wylosowane liczby parzyste:");
        for (int i = 0; i < evenNumbers.Count; i++)
        {
            Console.Write(evenNumbers[i]);

            if (i < evenNumbers.Count - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba faktycznych losowań: " + count);
    }
}