using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            if (i % 2 == 0) // parzysty wiersz
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
            else // nieparzysty wiersz
            {
                for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba;
                    liczba++;
                }
            }
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}