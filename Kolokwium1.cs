using System;
using System.Collections.Generic;
using System.Linq;
//WARIANT 2 Krystian Kręcik 162847

namespace ProgramowanieObiektowe
{
    public class Program
    {
        public static void rown(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Rozwiazanie Kazdy x");
                else
                    Console.WriteLine("Brak rozwiazan");
            }
            else
                Console.WriteLine("Rozwiazanie x={0}",((double)3 / 2)*(b/a));
        }
        public static int [,] wczytajDoTab(int n)
        {
            int[,] tab = new int[n, n];
            Console.WriteLine("Tworze tablice dwuwymiarowa {0} x {0}", n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Podaj wartosc");
                    tab[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            return tab;
        }
        public static void wyswietlTab(int n, int [,]tab)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,4}", tab[i, j]);
                Console.WriteLine();
            }
        }
        public static int najwiekszaSuma(int [,] tab)
        {
            int n = tab.GetLength(0);
            int[] sumaKolumn = new int[n]; // index 0 -> suma kol 0, index 1 -> suma kol 1
            for (int kolumna = 0; kolumna < n; kolumna++)
                for (int wiersz = 0; wiersz < n; wiersz++)
                    sumaKolumn[kolumna] += tab[wiersz, kolumna];
            int max_suma = sumaKolumn[0];
            for(int i = 0;i< sumaKolumn.Length; i++)
            {
                if (sumaKolumn[i] > max_suma)
                    max_suma = sumaKolumn[i];
                Console.WriteLine("Kolumna: {0}, suma={1}", i, sumaKolumn[i]);
            }
            return max_suma;
        }
        public static void Main(string[] args)
        {
            // Zadanie 1
            Console.WriteLine("Zadanie 1");
            Console.Write("Podaj liczbe a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj liczbe b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wczytales a = {0}, b = {1}", a, b);
            rown(a, b);

            Console.WriteLine("Wcisnij enter, aby przejsc dalej");
            Console.ReadKey();

            //Zadanie 2
            Console.WriteLine("\nZadanie 2");
            int n;
            do
            {
                Console.WriteLine("Podaj n <= 10");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n > 10);

            int[,] tablica2 = wczytajDoTab(n);
            wyswietlTab(n, tablica2);
            Console.WriteLine("Najwieksza suma wartosci w kolumnie wynosi={0}", najwiekszaSuma(tablica2));

            Console.WriteLine("Wcisnij enter, aby przejsc dalej");
            Console.ReadKey();

            //Zadanie 3
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Podaj liczbe naturalna");
            int n_zad3 = Convert.ToInt32(Console.ReadLine());
            int parzyste = 0, nieparzyste = 0;
            Console.WriteLine("Wczytales liczbe naturalna n = {0}", n_zad3);
            int[] tab_3 = new int[n_zad3];
            Console.WriteLine("Podaj teraz {0} liczb naturalnych", n_zad3);
            for (int i = 0; i < n_zad3; i++)
            {
                Console.Write("{0}/{1}: ", i + 1, n_zad3);
                tab_3[i] = Convert.ToInt32(Console.ReadLine());
                if (tab_3[i] % 2 == 0)
                    parzyste++;
                else
                    nieparzyste++;
            }
            Console.WriteLine("\nWczytales takie liczby: ");
            foreach (int el in tab_3)
                Console.Write("{0,3}", el);
            Console.WriteLine("\nWsrod twoich liczb jest: ");
            Console.WriteLine("Parzyste: {0}", parzyste);
            Console.WriteLine("Nieparzyste: {0}", nieparzyste);

            Console.WriteLine("Wcisnij enter, aby przejsc dalej");
            Console.ReadKey();

            // Zadanie 4
            Console.WriteLine("Zadanie 4");
            Console.Write("Podaj lancuch znakow: ");
            string tekst = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wczytales podany lancuch znakow: {0}", tekst);

            Dictionary<char, int> mapowanie = new Dictionary<char, int>();
            foreach (char znak in tekst)
                if (mapowanie.ContainsKey(znak))
                    mapowanie[znak] += 1;
                else
                    mapowanie[znak] = 1;
            foreach (KeyValuePair<char, int> znak in mapowanie)
                Console.WriteLine("{0} - {1}", znak.Key, znak.Value);

            Console.WriteLine("Wcisnij enter, aby przejsc dalej");
            Console.ReadKey();
        }
    }
}
