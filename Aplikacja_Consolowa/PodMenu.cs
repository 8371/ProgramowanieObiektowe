using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe5_6
{
    class PodMenu
    {
        static string[] pozycjeMenu = { "Kalkulator", "Gwiazdki", "Wylicz BMI", "Koniec" };
        static int aktywnaPozycjaMenu = 0;
        public static void StartMenu()
        {
            Console.SetWindowSize(45, 20);
            Console.Title = "Sztuczki i kruczki C# - zakres podstawowy";
            Console.CursorVisible = false;
            while (true)
            {
                PokazMenu();
                WybieranieOpcji();
                UruchomOpcje();
            }
        }

        static void PokazMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray; // kolor czcionki
            Console.WriteLine(">>> Sztuczki i kruczki C# <<<");
            Console.WriteLine();
            for (int i = 0; i < pozycjeMenu.Length; i++)
            {
                if (i == aktywnaPozycjaMenu)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0,-45}", pozycjeMenu[i]);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    Console.WriteLine(pozycjeMenu[i]);
                }
            }
        }
        static void WybieranieOpcji()
        {
            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu > 0) ? aktywnaPozycjaMenu - 1 : pozycjeMenu.Length - 1;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu + 1) % pozycjeMenu.Length;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    aktywnaPozycjaMenu = pozycjeMenu.Length - 1;
                    break;
                }
                else if (klawisz.Key == ConsoleKey.Enter)
                    break;
            } while (true);
        }

        static void UruchomOpcje()
        {
            switch (aktywnaPozycjaMenu)
            {
                case 0: Console.Clear(); opcjaKalkulator(); break;
                case 1: Console.Clear(); opcjaGwiazdki(); break;
                case 2: Console.Clear(); opcjaBMI(); break;
                case 3: Environment.Exit(0); break;
            }
        }
        public static double klawiszInput(string znak_x)
        {
            Console.Write("Podaj liczbe: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        private static void opcjaKalkulator()
        {
            Kalkulator kalkulator = new Kalkulator();
            ConsoleKeyInfo klawisz;
            do
            {
                Console.Clear();
                kalkulator.dostepneDzialania();
                kalkulator.set_x = klawiszInput("x");
                kalkulator.set_y = klawiszInput("y");

                Console.WriteLine("x={0}, y={1}", kalkulator.set_x, kalkulator.set_y);
                kalkulator.wyswietlLiczby();

                kalkulator.dostepneDzialania();
                Console.Write("Wybierz dzialanie: ");
                char dzialanie = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Wybrales znak: {0}", dzialanie);
                kalkulator.dzialanie(dzialanie);
                Console.WriteLine("Jesli chcesz wyjsc z programu\nwcisnij dwa razy ESC");
                klawisz = Console.ReadKey();
            } while (klawisz.Key != ConsoleKey.Escape);
        }
        public static void rysuj(char wybor, int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                    if (wybor == 'd')
                        if ((i == 0 || i == x - 1) || (j == 0 || j == x - 1))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    else if (wybor == 'a')
                    {
                        if (i + 1 > j)
                            Console.Write("*");
                    }
                    else if (wybor == 'b')
                    {
                        if (j + 1 > i)
                            Console.Write("*");
                    }
                    else if (wybor == 'c')
                    {
                        if (j < i)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                Console.WriteLine();
            }
        }
        private static void opcjaGwiazdki()
        {
            Kalkulator kalkulator = new Kalkulator();
            ConsoleKeyInfo klawisz;
            do
            {
                Console.Clear();
                Console.WriteLine("Gwiazdki");
                Console.Write("Podaj liczbe wierszy: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj wybierz wariant (a, b, c, d):");

                string wybor = Console.ReadLine();
                rysuj(Convert.ToChar(wybor), x);
                Console.WriteLine("Jesli chcesz wyjsc z programu\nwcisnij  ESC");
                klawisz = Console.ReadKey();
            } while (klawisz.Key != ConsoleKey.Escape);

        }
        private static void opcjaBMI()
        {
            ConsoleKeyInfo klawisz;
            do
            {
                Console.Clear();
                Console.WriteLine("Wylicz BMI");
                BMI bmi_ = new BMI();
                Console.Write("Podaj wage: ");
                bmi_.set_waga = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wzrost: ");
                bmi_.set_wzrost = Convert.ToDouble(Console.ReadLine());
                bmi_.obliczBMI();
                bmi_.wskBMI();
                Console.WriteLine("Jesli chcesz wyjsc wcisnij Esc");
                Console.WriteLine("Jesli nie wcisnij Enter");
                klawisz = Console.ReadKey();
            } while (klawisz.Key != ConsoleKey.Escape);
        }
    }
}
