using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;

        int wiersze = tablica.GetLength(0);
        int kolumny = tablica.GetLength(1);
        int dol = 0;
        int gora = wiersze - 1;
        int lewo = 0;
        int prawo = kolumny - 1;
        int kierunek = 0;

        while (dol <= gora && lewo <= prawo)
        {
            if (kierunek == 0)
            {
                for (int i = lewo; i <= prawo; i++)
                {
                    tablica[dol, i] = liczba;
                    liczba++;
                }
                dol++;
            }
            else if (kierunek == 1)
            {
                for (int i = dol; i <= gora; i++)
                {
                    tablica[i, prawo] = liczba;
                    liczba++;
                }
                prawo--;
            }
            else if (kierunek == 2)
            {
                for (int i = prawo; i >= lewo; i--)
                {
                    tablica[gora, i] = liczba;
                    liczba++;
                }
                gora--;
            }
            else if (kierunek == 3)
            {
                for (int i = gora; i >= dol; i--)
                {
                    tablica[i, lewo] = liczba;
                    liczba++;
                }
                lewo++;
            }

            kierunek = (kierunek + 1) % 4;
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
