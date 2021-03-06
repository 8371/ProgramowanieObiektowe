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
Napisz program zawieraj??cy metod?? statyczn?? obliczaj??c?? temperatur?? w stopniach
Fahrenheita na temperatur?? w stopniach Celsjusza. Metoda ma przyjmowa?? jeden argument
(temperatur?? w stopniach Fahrenheita) i zwraca?? temperatur?? w stopniach Celsjusza*/
            Console.WriteLine("Podaj temperature w stopniach Fahrenheita");
            double F = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zamiana/n {0:F2}^o F = {1:F2}^o C", F, fahrenToCel(F));

            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Zadanie 5.2.
Napisz program wczytuj??cy 3 liczby rzeczywiste a, b, x, a nast??pnie wywo??uj??cy
metod??, kt??ra sprawdza, czy liczba x nale??y do przedzia??u obustronnie otwartego(a, b).
Metoda sprawdzaj??ca ma zwr??ci?? warto???? logiczn??, kt??r?? nale??y zinterpretowa?? w metodzie
Main() z podaniem stosownego komunikatu. */
            Console.WriteLine("Podaj trzy liczby rzeczywiste: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            bool result = numBetweenAB(a, b, x);
            if (result)
                Console.WriteLine("Twoja liczba:{0}, nalezy do przedzia??u:({1}, {2})", x, a, b);
            else
                Console.WriteLine("Twoja liczba:{0}, NIE nalezy do przedzia??u:({1}, {2})", x, a, b);
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*
             Zadanie 5.3.
Napisz program, kt??ry ma znale???? wsp????rz??dne punktu po przesuni??ciu o dany wektor.
W metodzie Main() wczytaj od u??ytkownika wsp????rz??dne punktu A oraz zadeklaruj
wsp????rz??dne wektora wek [3, 2], a nast??pnie wywo??aj metod?? o nazwie Przesun(), kt??ra ma
przesun???? punkt A o wektor wek (doda?? odpowiednie wsp????rz??dne). Wsp????rz??dne punktu
(jako dwie zmienne typu double) maj?? zosta?? przes??ane do tej metody przez referencj??, a
wsp????rz??dne wektora (tak??e jako dwie zmienne typu double) przez warto????. Metoda
Przesun() ma nic nie zwraca?? (void), aktualne wsp????rz??dne punktu maj?? by?? pami??tane dzi??ki
u??yciu argument??w przesy??anych przez referencje. Program ma wy??wietli?? wsp????rz??dne
punktu po przesuni??ciu o wektor wek. Przyk??adowo, gdyby u??ytkownik poda?? pocz??tkowe
wsp????rz??dne punktu A (2, 1), to w??wczas program znajdzie po??o??enie punktu A po
przesuni??ciu w miejscu o wsp????rz??dnych (5, 3) (czyli 2+3, 1+2). */
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
Napisz program, kt??ry mno??y elementy tablicy jednowymiarowej przez zadan?? liczb??.
Mno??enie ma by?? wykonane w metodzie statycznej przyjmuj??cej jako argumenty tablic?? typu
int oraz liczb?? ca??kowit?? (mno??nik). Wykonaj zadanie w dw??ch wariantach:
a) Wewn??trz metody tworzona jest nowa tablica wynikowa, kt??ra ma by?? zwr??cona
przez metod??.
b) Wyniki mno??enia element??w tablicy maj?? zosta?? umieszczone w tablicy b??d??cej
argumentem metody (w tym wariancie metoda ma niczego nie zwraca??).
Przyk??adowo dla tablicy o elementach {1,4,6,8,2} oraz mno??niku 2 program powinien
wy??wietli?? tablic?? {2,8,12,16,4}.
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
            /*Napisz program, kt??ry wypisze na ekranie znaki w kszta??cie prostok??ta. Program ma
prosi?? u??ytkownika o podanie rozmiaru prostok??ta: d??ugo???? i szeroko????, a nast??pnie znak,
kt??rym ma by?? zape??niony prostok??t. Napisz metod?? Rysuj(), kt??ra wypisze na konsoli
prostok??t, przesy??aj??c jako argument d??ugo????, szeroko???? oraz znak wype??nienia. Wywo??aj
metod?? dwa razy, za drugim razem podaj na odwr??t argumenty dla d??ugo??ci i szeroko??ci.
W wyniku dzia??ania programu powinny zosta?? wy??wietlone dwa prostok??ty, jeden ???le????cy???
oraz drugi ???stoj??cy???. Przyk??adowy przebieg dzia??ania programu na rysunku:
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
Uzupe??nij program z zadania 5.4 (dowolny wariant) o metod?? prze??adowan??
przyjmuj??c?? tablic?? typu string oraz mno??nik typu int. W tym przypadku metoda ma powiela??
??a??cuch znak??w (konkatenowa?? tyle razy, ile wynika z mno??nika). Przyk??adowo dla tablicy o
elementach {"ala", "kot", "dom"} oraz mno??niku 2 program powinien wy??wietli?? tablic??
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
Napisz statyczn?? metod??, kt??ra oblicza wyra??enie:
W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywo??aj funkcj?? dla x i n
(liczb naturalnych) wczytanych z klawiatury.*/
            int x11 = 3, n = 3;
            Console.WriteLine("Wynik wyrazenia W = (x+1) + (x+2) + ... (x+n)");
            Console.WriteLine("Dla x={0}, n={1}", x11, n);
            Console.WriteLine("Wynosi: {0}", Expression(x11, n));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Zadanie 5.8.
Napisz metod??, kt??ra oblicza sum?? cyfr liczby naturalnej x. W programie g????wnym
wywo??aj funkcj?? dla x wczytanego z klawiatury. Przyk??adowo je??li u??ytkownik wpisze 125,
to metoda powinna zwr??ci?? warto???? 8 (1+2+5=8). */
            Console.WriteLine("Podaj liczbe naturalna: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            foreach (char el in Convert.ToString(x3))
                Console.WriteLine(el);
            Console.WriteLine("Suma cyfr liczby: {0} wynosi: {1}", x3, sumDigits(x3));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
            /*Wykonaj program znajduj??cy n-ty wyraz ci??gu Fibonacciego wed??ug wzoru
             * Wykonaj program w dw??ch wariantach: w jednym metoda znajduj??ca wyraz ci??gu ma
by?? rekurencyjna, a w drugim ma wykorzysta?? iteracyjne podej??cie (z u??yciem p??tli). 
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
            /*Jaki b??dzie rezultat metody Oblicz() wywo??anej z parametrem n = 5? Zadanie wykonaj
najpierw bez udzia??u kompilatora, a dopiero p????niej uruchom program i sprawd?? otrzymany
wynik.*/ //1+2+3+4+5=3+3+9=15
            Console.WriteLine("Dla n=5 powinna byc suma liczb od 1 do 5");
            Console.WriteLine("Wynik={0}", Oblicz(5));
            Console.WriteLine("Wcisnij klawisz");
            Console.ReadKey();
        }
    }
}
