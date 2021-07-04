using System;
using System.IO;

namespace _139
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Obłożenie hotelu");
                int liczbaPokoi, zajętePokoie;
                InpuDate(out liczbaPokoi, out zajętePokoie);
                int lol, lol1;
                OutPutDate(liczbaPokoi, zajętePokoie, out lol, out lol1);

                Zapisywanie(zajętePokoie, lol, lol1);
                Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                string end = Console.ReadLine();
                if (end.Equals("tak", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                Console.Clear();
            }
        }

        private static void Zapisywanie(int zajętePokoie, int lol, int lol1)
        {
            StreamWriter inputDate = File.CreateText("Hotel.text");

            inputDate.WriteLine(lol);
            inputDate.WriteLine(zajętePokoie);
            inputDate.WriteLine(lol1);
            inputDate.Close();
        }

        private static void OutPutDate(int liczbaPokoi, int zajętePokoie, out int lol, out int lol1)
        {
            lol = liczbaPokoi / zajętePokoie;
            lol1 = liczbaPokoi - zajętePokoie;
            Console.WriteLine("============================");
            Console.WriteLine($"Poziom obłożenia hotelu to {lol}.");
            Console.WriteLine($"Liczba zajętych pokoi to {zajętePokoie}.");
            Console.WriteLine($"Liczba wolnyc pokoi to {lol1}.");
        }

        private static void InpuDate(out int liczbaPokoi, out int zajętePokoie)
        {
            Console.WriteLine("Wprwoadź liczbę pieter: ");
            int piętra = int.Parse(Console.ReadLine());
            int[] pokoie = new int[piętra];
            int[] wolnePokoie = new int[piętra];

            liczbaPokoi = 0;
            for (int i = 0; i < piętra; i++)
            {
                Console.WriteLine($"Wprowadź liczbę pokoi na piętrze {i + 1}.");
                pokoie[i] = int.Parse(Console.ReadLine());
                while (pokoie[i] < 10)
                {
                    Console.WriteLine("Liczba pokoi jest za mała wprowadź liczbę większą niż 10:");
                    pokoie[i] = int.Parse(Console.ReadLine());
                }


                liczbaPokoi += pokoie[i];

            }
            zajętePokoie = 0;
            for (int i = 0; i < piętra; i++)
            {
                Console.WriteLine($"Wprowadź liczbę zajętych pokoi z piętra {i + 1}.");
                wolnePokoie[i] = int.Parse(Console.ReadLine());
                zajętePokoie += wolnePokoie[i];

            }
        }
    }
}
