using System;
using System.Linq;
using System.Collections.Generic;

namespace ProgramowanieObiektowe5_6
{
    public class Prostokat
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double dlugosc_, double szerokosc_)
        {
            dlugosc = dlugosc_;
            szerokosc = szerokosc_;
        }
        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        private double obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }
        public static void wyswietlKilka(Prostokat[] tab)
        {
            foreach (Prostokat pros in tab)
                pros.Prezentuj();
        }
        public static double maxArea(Prostokat[] tab)
        {
            return (from pros in tab select pros.powierzchnia()).Max();
        }
        public void Prezentuj()
        {
            Console.WriteLine("Prostokat o wymiarach: {0}x{1}", dlugosc, szerokosc);
            Console.WriteLine("Area: {0}", powierzchnia());
            Console.WriteLine("Perimeter: {0}", obwod());
        }
    }
    public class Energia
    {
        private double poczatkowy_stan;
        double bierzacy_stan;

        public Energia(double poczStan, double bierzStan)
        {
            poczatkowy_stan = poczStan;
            bierzacy_stan = bierzStan;
        }
        public void stanLicznika()
        {
            Console.WriteLine("Poczatkowy stan licznika: {0} kWh", poczatkowy_stan);
            Console.WriteLine("Bierzacy stan licznika: {0} kWh", bierzacy_stan);
        }
        public void zuzytaEnergia()
        {
            Console.WriteLine("Zuzyta energia: {0} kWh", bierzacy_stan - poczatkowy_stan);
        }
    }

    public class Punkt
    {
        public int x;
        public int y;
        public Punkt(int xx, int yy)
        {
            x = xx;
            y = yy;
        }
        public void Przesun(int a, int b)
        {
            Console.WriteLine("Przesuwam pkt o wektor [{0}, {1}]", a, b);
            x += a;
            y += b;
        }
        public void Wyswietl()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
        public static bool wspolliniowe(Punkt[] tab)
        {
            foreach (Punkt pkt in tab)
                pkt.Wyswietl();
            return ((tab[1].x-tab[0].x)*(tab[2].y-tab[0].y)-(tab[1].y-tab[0].y)*(tab[2].x-tab[0].x)) == 0;
        }
    }
    public class Odcinek
    {
        public Punkt a;
        public Punkt b;
        public Odcinek(Punkt x, Punkt y)
        {
            a = x;
            b = y;
        }
        public double dlugoscOdcinka()
        {
            return Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2));
        }
    }
    public class Prostopadloscian
    {
        public int dlugosc;
        public int szerokosc;
        public int wysokosc;
        public Prostopadloscian(int x, int y, int z)
        {
            dlugosc = x;
            szerokosc = y;
            wysokosc = z;
        }
        public double area()
        {
            return 2 * (dlugosc * szerokosc + dlugosc * wysokosc + szerokosc * wysokosc);
        }
        public double volume()
        {
            return dlugosc * szerokosc * wysokosc;
        }
        public static bool compareTwo(Prostopadloscian prost1, Prostopadloscian prost2)
        {
            return prost1.volume() > prost2.volume();
        }
    }
    struct Prostokat1
    {
        private double dlugosc;
        private double szerokosc;
        public Prostokat1(double x, double y)
        {
            dlugosc = x;
            szerokosc = y;
        }
        private double powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        private double obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Prostokat o wymiarach: {0}x{1}", dlugosc, szerokosc);
            Console.WriteLine("Area: {0}", powierzchnia());
            Console.WriteLine("Perimeter: {0}", obwod());
        }
        public static void wyswietlKilka(Prostokat1[] tab)
        {
            foreach (Prostokat1 pros in tab)
                pros.Prezentuj();
        }
        public static double maxArea(Prostokat1[] tab)
        {
            return (from pros in tab select pros.powierzchnia()).Max();
        }
    }
    struct KandydatNaStudia
    {
        private string nazwisko;
        private double punktyMatematyka;
        private double punktyInformatyka;
        private double punktyJezykObcy;
        public KandydatNaStudia(string nazw, double pktMat, double pktInf, double pktJez)
        {
            nazwisko = nazw;
            punktyMatematyka = pktMat;
            punktyInformatyka = pktInf;
            punktyJezykObcy = pktJez;
        }
        public double Oblicz()
        {
            return 0.6 * punktyMatematyka + 0.5 * punktyInformatyka + 0.2 * punktyJezykObcy;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Nazwisko: {0}, Punkty: {1}", nazwisko, Oblicz());
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             Zadanie 6.1.
Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane
składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę
publiczną – Prezentuj() (która wyświetla powierzchnię i obwód prostokąta) i konstruktor
inicjalizujący. W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj()*/
            Prostokat pracownik = new Prostokat(5, 5);
            pracownik.Prezentuj();
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.2.
Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla
prostokątów. W metodzie Main() wyświetl powierzchnie oraz obwód wszystkich prostokątów
w tablicy używając (wewnątrz pętli foreach) metody publicznej Prezentuj()*/
            Prostokat[] prosTabs = new Prostokat[]
            {
                            new Prostokat(4.3, 2),
                            new Prostokat(1, 1),
                            new Prostokat(40, 10),
            };
            Prostokat.wyswietlKilka(prosTabs);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.3.
Uzupełnij program z poprzedniego zadania o definicję metody statycznej, która podaje
powierzchnię największego prostokąta.*/
            Prostokat[] prosTabs1 = new Prostokat[]
                        {
                                        new Prostokat(4.3, 2),
                                        new Prostokat(1, 1),
                                        new Prostokat(40, 10),
                        };
            Console.WriteLine(Prostokat.maxArea(prosTabs1));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.4.
Zdefiniuj klasę, która pozwoli na rejestrację zużycia energii elektrycznej. Klasa
powinna pozwalać na:
 rejestrację początkowego i bieżącego stanu licznika energii,
 uzyskanie danych o początkowym oraz bieżącym stanie licznika,
 obliczanie zużytej energii.*/
            Energia energ = new Energia(1250, 2367);
            energ.stanLicznika();
            energ.zuzytaEnergia();
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.5.
Napisz program tworzący klasę Punkt do obsługi punktów na płaszczyźnie. Klasa ta ma
zawierać: konstruktor, którego argumentami będą współrzędne punktu, metodę składową
Przesun(), realizującą przesunięcie o zadane wielkości oraz metodę składową Wyswietl()
wypisującą aktualne współrzędne punktu. Współrzędne punktu mają być zdefiniowane
poprzez właściwości.*/
            Punkt pkt = new Punkt(5, 3);
            pkt.Wyswietl();
            pkt.Przesun(10, 10);
            pkt.Wyswietl();
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.6.
Napisz program (używając klasy Punkt zdefiniowanej w poprzednim zadaniu), który
przechowuje dane o trzech punktach w tablicy obiektów i sprawdza przy pomocy statycznej
metody, czy leżą one na jednej prostej. */
            Punkt[] punkty = new Punkt[]
            {
                            new Punkt(-5, -3),
                            new Punkt(0, -1),
                            new Punkt(10, 3),
            };
            Punkt[] punkty2 = new Punkt[]
            {
                            new Punkt(-5, 2),
                            new Punkt(2, -1),
                            new Punkt(9, -5),
            };

            if (Punkt.wspolliniowe(punkty))
                Console.WriteLine("Punkty sa wspolliniowe");
            else
                Console.WriteLine("Punkty nie sa wspolliniowe");
            if (Punkt.wspolliniowe(punkty2))
                Console.WriteLine("Punkty sa wspolliniowe");
            else
                Console.WriteLine("Punkty nie sa wspolliniowe");

            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.7.
Zdefiniuj klasę Odcinek składającą się z dwóch punktów klasy Punkt. W klasie Odcinek
zdefiniuj metodę, która obliczy długość odcinka.*/
            Punkt[] pkty = new Punkt[] {
                            new Punkt(3, 4),
                            new Punkt(-1, 6)
                        };
            Odcinek odc = new Odcinek(pkty[0], pkty[1]);
            Console.WriteLine("Dlugosc odcinka [{0}, {1}]---[{2}, {3}]={4:F2}",
                              pkty[0].x, pkty[0].y, pkty[1].x, pkty[1].y, odc.dlugoscOdcinka());
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.8.
Zdefiniuj klasę Prostopadloscian, która pozwoli na reprezentację danych opisujących
długość, szerokość i wysokość prostopadłościanu. W klasie zaimplementuj metody
pozwalające na obliczenie objętości prostopadłościanu, oraz porównanie objętości dwóch
prostopadłościanów.*/
            Prostopadloscian prost1 = new Prostopadloscian(3, 4, 5);
            Console.WriteLine("Prostopadloscian o wymiarach: {0}x{1}x{2}", 3, 4, 5);
            Console.WriteLine("Pole prostopadoscianu: {0}", prost1.area());
            Console.WriteLine("Objetosc prostopadoscianu: {0}", prost1.volume());
            Console.WriteLine();
            Prostopadloscian prost2 = new Prostopadloscian(5, 4, 6);
            Console.WriteLine("Prostopadloscian o wymiarach: {0}x{1}x{2}", 5, 4, 6);
            Console.WriteLine("Pole prostopadoscianu: {0}", prost2.area());
            Console.WriteLine("Objetosc prostopadoscianu: {0}", prost2.volume());
            Console.WriteLine();
            if (Prostopadloscian.compareTwo(prost1, prost2))
                Console.WriteLine("Prostopadloscian_1 ma wieksza objetosc niz Prostopadloscian_2");
            else
                Console.WriteLine("Prostopadloscian_2 ma wieksza objetosc niz Prostopadloscian_1");
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.9.
Wykonaj zadania 6.1 oraz 6.2 z użyciem struktury (zamiast klasy).*/
            Prostokat1 prost0 = new Prostokat1(4, 5);
            Prostokat1[] prosTabs2 = new Prostokat1[]
            {
                                        new Prostokat1(4.3, 2),
                                        new Prostokat1(1, 1),
                                        new Prostokat1(40, 10),
            };
            Prostokat1.wyswietlKilka(prosTabs2);
            prost0.Prezentuj();
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();

            /*Zadanie 6.10.
Napisz program z użyciem struktury KandydatNaStudia, która ma posiadać następujące
pola: nazwisko, punktyMatematyka, punktyInformatyka, punktyJezykObcy. W trzech ostatnich
polach mają być zapisane punkty za przedmioty zdawane na maturze (dla uproszczenia
uwzględniamy tylko jeden poziom zdawanej matury, np. podstawowy). Jeden punkt to jeden
procent (tj. student, który ma 55% z matematyki ma mieć 55 punktów z tego przedmiotu).
Struktura ma posiadać metodę obliczającą łączną liczbę punktów kandydata według
przelicznika: 0,6 punktów z matematyki + 0,5 punktów z informatyki + 0,2 punktów z języka
obcego. W metodzie Main() utwórz obiekty dla struktury (jako elementy tablicy) dla kilku
kandydatów i pokaż listę kandydatów, zawierającą nazwisko i obok, w tej samej linii,
obliczoną łączną liczbę punktów.
*/
            KandydatNaStudia[] kandydaci = new KandydatNaStudia[]
            {
                new KandydatNaStudia("John", 80, 75, 95),
                new KandydatNaStudia("Ev", 50, 30, 80),
                new KandydatNaStudia("Top", 90, 90, 90),
            };
            foreach (KandydatNaStudia kand in kandydaci)
                kand.Wyswietl();

            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
        }
    }
}
