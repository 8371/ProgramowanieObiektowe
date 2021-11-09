using System;
using System.Linq;
using System.Collections.Generic;

namespace ProgramowanieObiektowe5_6
{
    public class Program
    {
        public static double fahrenToCel(double F)
        {
            return ((F - (double)32) * 5) / (double)9;
        }
        public static bool numBetweenAB(double a, double b, double x)
        {
            return (a < x) && (x < b);
        }
        public static void Przesun(ref double a, ref double b, int []wek)
        {
            a += wek[0];
            b += wek[1];
        }
        public static int [] mnoznikNowa(int [] tab, int mnoznik)
        {
            return tab.Select(el => el * mnoznik).ToArray();
        }
        public static void mnoznikRef(ref int []tab, int mnoznik)
        {
            tab = tab.Select(el => el * mnoznik).ToArray();
        }
        public static void Rysuj(int wysokosc, int szerokosc, char znak)
        {
            Console.WriteLine("Rysuje prostokat");
            for(int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                    Console.Write(znak);
                Console.WriteLine();
            }
        }
        public static string[] mnoznikNowa(string []tab, int mnoznik)
        {
            return tab.Select(rh => String.Concat(Enumerable.Repeat(rh, mnoznik))).ToArray();
        }
        public static int Expression(int x, int n)
        {
            return (from el in Enumerable.Range(1, n) select el + x).Sum();
        }
        public static int sumDigits(int x)
        {
            return (from value in Convert.ToString(x) select Int32.Parse(Convert.ToString(value))).Sum();
        }
        public static int Fib(int x)
        {
            if (x == 0)
                return 0;
            if (x==1 || x==2)
                return 1;
            return Fib(x - 1) + Fib(x - 2);
        }
        public static int Fib2(int x)
        {
            if (x == 0)
                return 0;
            if (x == 1 || x == 2)
                return 1;
            int fib=1, prev = 1, next=1;
            for(int i = 3; i <= x; i++)
            {
                fib = next + prev;
                prev = next;
                next = fib;
            }
            return fib;
        }
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
        static void Main(string[] args)
        {
            /*Zadanie 5.1.
Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach
Fahrenheita na temperaturę w stopniach Celsjusza. Metoda ma przyjmować jeden argument
(temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza*/
            Console.WriteLine("Podaj temperature w stopniach Fahrenheita");
            double F = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zamiana/n {0:F2}^o F = {1:F2}^o C", F, fahrenToCel(F));

            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Zadanie 5.2.
Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący
metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego(a, b).
Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie
Main() z podaniem stosownego komunikatu. */
            Console.WriteLine("Podaj trzy liczby rzeczywiste: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            bool result = numBetweenAB(a, b, x);
            if (result)
                Console.WriteLine("Twoja liczba:{0}, nalezy do przedziału:({1}, {2})", x, a, b);
            else
                Console.WriteLine("Twoja liczba:{0}, NIE nalezy do przedziału:({1}, {2})", x, a, b);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*
             Zadanie 5.3.
Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor.
W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj
współrzędne wektora wek [3, 2], a następnie wywołaj metodę o nazwie Przesun(), która ma
przesunąć punkt A o wektor wek (dodać odpowiednie współrzędne). Współrzędne punktu
(jako dwie zmienne typu double) mają zostać przesłane do tej metody przez referencję, a
współrzędne wektora (także jako dwie zmienne typu double) przez wartość. Metoda
Przesun() ma nic nie zwracać (void), aktualne współrzędne punktu mają być pamiętane dzięki
użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne
punktu po przesunięciu o wektor wek. Przykładowo, gdyby użytkownik podał początkowe
współrzędne punktu A (2, 1), to wówczas program znajdzie położenie punktu A po
przesunięciu w miejscu o współrzędnych (5, 3) (czyli 2+3, 1+2). */
            Console.WriteLine("Podaj wspolrzedne punktu A: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wspolrzedne punktu A=[{0}, {1}]", x1, x2);
            int[] wek = { 3, 2 };
            Console.WriteLine("Przesuwam punkt A o wektor wek=[{0}, {1}]", wek[0], wek[1]);
            Przesun(ref x1, ref x2, wek);
            Console.WriteLine("Wspolrzedne punktu A=[{0}, {1}]", x1, x2);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*
             Zadanie 5.4.
Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę.
Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
int oraz liczbę całkowitą (mnożnik). Wykonaj zadanie w dwóch wariantach:
a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona
przez metodę.
b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej
argumentem metody (w tym wariancie metoda ma niczego nie zwracać).
Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien
wyświetlić tablicę {2,8,12,16,4}.
            */
            const int mnoznik = 3;
            Console.WriteLine("Mnoze wektor A przez {0}", mnoznik);
            int[] wek4 = new int[] { 8, -2, 3, 4, 10, 15 };
            foreach (int el in wek4)
                Console.Write("{0,-3}", el);
            Console.WriteLine("\nPo mnozeniu zwracam nowa tablice:");
            foreach (int el in mnoznikNowa(wek4, mnoznik))
                Console.Write("{0,-3}", el);
            Console.WriteLine("\nPo mnozeniu zwracam ta sama tablice:");
            mnoznikRef(ref wek4, mnoznik);
            foreach (int el in wek4)
                Console.Write("{0,-3}", el);
            Console.WriteLine("\nWcisnij klawisz");
            Console.ReadKey();
            /*Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma
prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak,
którym ma być zapełniony prostokąt. Napisz metodę Rysuj(), która wypisze na konsoli
prostokąt, przesyłając jako argument długość, szerokość oraz znak wypełnienia. Wywołaj
metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości.
W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący”
oraz drugi „stojący”. Przykładowy przebieg działania programu na rysunku:
*/
            Console.WriteLine("Podaj szerokosc prostokata: ");
            int szerokosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc prostokata: ");
            int wysokosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj znak ktorym wypelnie prostokat: ");
            char znak = Convert.ToChar(Console.ReadLine());
            Rysuj(szerokosc, wysokosc, znak);
            Rysuj(wysokosc, szerokosc, znak);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*
             Zadanie 5.6.
Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną
przyjmującą tablicę typu string oraz mnożnik typu int. W tym przypadku metoda ma powielać
łańcuch znaków (konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o
elementach {"ala", "kot", "dom"} oraz mnożniku 2 program powinien wyświetlić tablicę
{"alaala", "kotkot", "domdom"}.
*/
            string[] slowa = new string[] { "ala", "kot", "dom" };
            Console.WriteLine("Wypisuje slowa: ");
            foreach (string slowo in slowa)
                Console.WriteLine("{0}", slowo);
            Console.WriteLine("Wypisuje po konkatenacji {0} razy.", 2);
            foreach (string slowo in mnoznikNowa(slowa, 2))
                Console.WriteLine("{0}", slowo);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*
             Zadanie 5.7.
Napisz statyczną metodę, która oblicza wyrażenie:
W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywołaj funkcję dla x i n
(liczb naturalnych) wczytanych z klawiatury.*/
            int x11 = 3, n = 3;
            Console.WriteLine("Wynik wyrazenia W = (x+1) + (x+2) + ... (x+n)");
            Console.WriteLine("Dla x={0}, n={1}", x11, n);
            Console.WriteLine("Wynosi: {0}", Expression(x11, n));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Zadanie 5.8.
Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym
wywołaj funkcję dla x wczytanego z klawiatury. Przykładowo jeśli użytkownik wpisze 125,
to metoda powinna zwrócić wartość 8 (1+2+5=8). */
            Console.WriteLine("Podaj liczbe naturalna: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            foreach (char el in Convert.ToString(x3))
                Console.WriteLine(el);
            Console.WriteLine("Suma cyfr liczby: {0} wynosi: {1}", x3, sumDigits(x3));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Wykonaj program znajdujący n-ty wyraz ciągu Fibonacciego według wzoru
             * Wykonaj program w dwóch wariantach: w jednym metoda znajdująca wyraz ciągu ma
być rekurencyjna, a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli). 
             */
            Console.WriteLine("Obliczam ciag Fib dla liczby n=10 i n=6");
            Console.WriteLine("Podejscie rekurencyjne: ");
            Console.WriteLine("n={0} wynik={1}", 10, Fib(10));
            Console.WriteLine("n={0} wynik={1}", 6, Fib(6));

            Console.WriteLine("Podejscie iteracyjne: ");
            Console.WriteLine("n={0} wynik={1}", 10, Fib2(10));
            Console.WriteLine("n={0} wynik={1}", 6, Fib2(6));

            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Jaki będzie rezultat metody Oblicz() wywołanej z parametrem n = 5? Zadanie wykonaj
najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany
wynik.*/ //1+2+3+4+5=3+3+9=15
            Console.WriteLine("Dla n=5 powinna byc suma liczb od 1 do 5");
            Console.WriteLine("Wynik={0}", Oblicz(5));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
        }
    }
}
