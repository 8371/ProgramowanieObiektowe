using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Zadanie 3.a.
             * Napisz program, który dla podanej przez użytkownika liczby 
             * całkowitej sprawdza, czy jest parzysta oraz czy jest ujemna. */
            //Console.WriteLine("Podaj liczbe calkowita: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(">" + x + "<");
            //if (x % 2 == 0)
            //    Console.Write("Twoja liczba jest parzysta. ");
            //else
            //    Console.Write("Twoja liczba jest nieparzysta. ");
            //if (x < 0)
            //    Console.Write("Twoja liczba jest ujemna. ");
            //else
            //    Console.Write("Twoja liczba jest dodatnia. ");
            /* Zadanie 3.b. 
             * Napisz program pobierający od użytkownika dwie liczby całkowite. 
             * Program powinien wypisać parzyste liczby znajdujące się pomiędzy podanymi wartościami
             */
            //Console.WriteLine("Podaj dwie liczby calkowite: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //int min = (x>=y?y:x);
            //y = (x >= y ? x : y);
            //Console.WriteLine("Wypisuje liczby parzyste pomiedzy {0} a {1}", min, y);
            //for(int i = (min%2==0?min:min+=1); i<= y; i+=2)
            //{
            //        Console.WriteLine(i);
            //}
            /* Zadanie 3.c.
* Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z 
nich codziennie będzie odkładał na spłatę zadłużenia 20% swojego dziennego zarobku, Janek 
zarabia dziennie 50 zł, a Karol 40 zł. Napisz program, który przy pomocy pętli do..while
sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną do spłaty swojego długu oraz 
wypisze wartość uzbieranej kwoty w każdym dniu.
            */
            //const int dlug = 80, Janek_zarobek = 50, Karol_zarobek = 40;
            //double odlozone = 0;
            //int dni = 0;
            //Console.WriteLine("Dlug: {0}, Janek zarobek: {1}, Karol zarobek: {2}", dlug, Janek_zarobek, Karol_zarobek);
            //do
            //{
            //    odlozone += Janek_zarobek * 0.2 + Karol_zarobek * 0.2;
            //    dni++;
            //    Console.WriteLine("Dzien: {0} odlozone: {1}", dni, odlozone);

            //} while (odlozone <= dlug);
            //Console.WriteLine("Janek I Karol odlozyli pieniadze po {0} dniach.", dni);
            /* Zadanie 3.d.
            Napisz program, który wyświetla na ekranie konsoli „kwadrat” zbudowany ze znaku 
            „*”. Liczbę wierszy (a tym samym kolumn) ma podać użytkownik
             */
            //Console.WriteLine("Podaj liczbe wierszy: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //        Console.Write("*");
            //Console.WriteLine();
            //}
            /*Zadanie 3.1.
Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok 
przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych 
przez 400).*/
            //Console.WriteLine("Podaj rok, sprawdzę czy jest przystępny: ");
            //int rok = Convert.ToInt32(Console.ReadLine());
            //if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0))
            //    Console.WriteLine("Rok: {0} jest rokiem przystepnym", rok);
            //else
            //    Console.WriteLine("Rok: {0} nie jest rokiem przystepnym", rok);
            /* 
             * Zadanie 3.2.
Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien 
wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej
             */
            //Console.WriteLine("Podaj dwie liczby calkowite: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (x % y == 0)
            //    Console.WriteLine("{0} jest dzielnikiem {1}", y, x);
            //else
            //    Console.WriteLine("{0} jest nie dzielnikiem {1}", y, x);
            /*Zadanie 3.3.
Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość 
największej z nich.*/
            //Console.WriteLine("Podaj trzy liczby: ");
            //double x, y, z;
            //x = Convert.ToDouble(Console.ReadLine());
            //y = Convert.ToDouble(Console.ReadLine());
            //z = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Najwieksza liczba to: {0}", (x > y ? (x > z ? x : z) : (y > z ? y : z)));
            /*Zadanie 3.4. 
Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik 
operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5 
oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0*/
            //Console.WriteLine("Podaj dwie liczby");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Podaj jeden z następujących znaków: +, -, *, /");
            //string znak = Console.ReadLine();
            //switch (znak)
            //{
            //    case "+":
            //        Console.WriteLine("Wynik dodawania: {0}", x + y);
            //        break;
            //    case "-":
            //        Console.WriteLine("Wynik odejmowania: {0}", x - y);
            //        break;
            //    case "*":
            //        Console.WriteLine("Wynik mnozenia: {0}", x * y);
            //        break;
            //    case "/":
            //        if (y == 0)
            //            Console.WriteLine("Nie dzielimy przez zero!");
            //        else
            //            Console.WriteLine("Wynik dzielenia: {0}", x / y);
            //        break;
            //    default:
            //        Console.WriteLine("Nieznana opercja");
            //        break;
            //}
            /*Zadanie 3.5. 
Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma 
prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić 
stosowny komunikat.*/
            //double A, B, C1, delta, x1, x2;
            //Console.WriteLine("Podaj wspolczynniki a, b, c: ");
            //A = double.Parse(Console.ReadLine());
            //B = double.Parse(Console.ReadLine());
            //C1 = double.Parse(Console.ReadLine());
            //delta = B * B - 4 * A * C1;
            //x1 = x2 = 0;
            //if (A == 0)
            //{
            //    Console.WriteLine("Nie dzielimy przez zero!");
            //}
            //else
            //{
            //    if (delta == 0)
            //    {
            //        x1 = x2 = -B / (2 * A);
            //    }
            //    if (delta > 0)
            //    {
            //        x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            //        x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            //    }
            //    if (delta < 0)
            //        Console.WriteLine("Brak rozwiązań");
            //    if (delta >= 0)
            //        Console.WriteLine("Wynik x1={0}, x2={1}", x1, x2);
            //    Console.ReadKey();
            //}
            /*Zadanie 3.6. 
Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić 
użytkownika o podanie wagi w kg oraz wzrostu w metrach. Wzór: 
2 wzrost
masa BMI
(treść 
zadania 2.3). 
a) Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w 
zależności od wartości wskaźnika:
 < 18,5 – niedowaga,
 18,5–24,99 – wartość prawidłowa,
 ≥ 25,0 – nadwaga.
b) Korzystając z Wikipedii rozszerz program, tak aby wyświetlał komentarz według
poszerzonej klasyfikacji zakresów wskaźnika BMI*/
            //Console.WriteLine("Podaj wage w kilogramach, podaj wzrost w metrach");
            //double waga, wzrost, bmi;
            //waga = double.Parse(Console.ReadLine());
            //wzrost = double.Parse(Console.ReadLine());
            //bmi = waga / (wzrost/100 * wzrost/100);
            //if (bmi < 16)
            //    Console.WriteLine("wygłodzenie, BMI={0}", bmi);
            //else if (bmi >= 16 && bmi <= 16.99)
            //    Console.WriteLine("wychudzenie, BMI={0}", bmi);
            //else if (bmi >= 17 && bmi <= 18.49)
            //    Console.WriteLine("Niedowaga, BMI={0}", bmi);
            //else if (bmi >= 18.5 && bmi <= 24.99)
            //    Console.WriteLine("Pożądana masa ciała, BMI={0}", bmi);
            //else if (bmi >= 25 && bmi <= 29.99)
            //    Console.WriteLine("Nadwaga, BMI={0}", bmi);
            //else if (bmi >= 30 && bmi <= 34.99)
            //    Console.WriteLine("Otylosc I stopnia, BMI={0}", bmi);
            //else if (bmi >= 35 && bmi <= 39.99)
            //    Console.WriteLine("Otylosc II stopnia (duża), BMI={0}", bmi);
            //else
            //    Console.WriteLine("Otylosc III stopnia (chorobliwa), BMI={0}", bmi);
            /*Zadanie 3.7.
Wykonaj program z przykładu 3.8 (str. 63) z użyciem instrukcji switch..case (zamiast if..else).*/
            //    Console.WriteLine("Wpisz nr dnia tygodnia");
            //    string numer = Console.ReadLine();
            //    switch (numer)
            //    {
            //        case "1":
            //            Console.WriteLine("Poniedziałek");
            //            break;
            //        case "2":
            //            Console.WriteLine("Wtorek");
            //            break;
            //        case "3":
            //            Console.WriteLine("Środa");
            //            break;
            //        case "4":
            //            Console.WriteLine("Czwartek");
            //            break;
            //        case "5":
            //            Console.WriteLine("Piątek");
            //            break;
            //        case "6":
            //            Console.WriteLine("Sobota");
            //            break;
            //        case "7":
            //            Console.WriteLine("Niedziela");
            //            break;
            //        default:
            //            Console.WriteLine("Nie ma takiego dnia tygodnia");
            //            break;
            //}
            /*Zadanie 3.8.
Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o 
wysokości przysługującego stypendium zgodnie z poniższą tabelą:*/
            //Console.WriteLine("Podaj srednia ocen: ");
            //double srednia = Convert.ToDouble(Console.ReadLine());
            //if (srednia > 2.00 && srednia <= 3.99)
            //    Console.WriteLine("Kwota stypendium: {0} zl", 0.00);
            //else if (srednia >= 4.00 && srednia <= 4.79)
            //    Console.WriteLine("Kwota stypendium: {0} zl", 350.00);
            //else if (srednia >= 4.80 && srednia <= 5.00)
            //    Console.WriteLine("Kwota stypendium: {0} zl", 550.00);
            /*Zadanie 3.9.
Napisz program w czterech wariantach (a, b, c i d), którego efektem działania będzie
„figura” utworzona ze znaku gwiazdki (*) przedstawiona na danym rysunku.*/
            //Console.WriteLine("Podaj liczbe wierszy: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj wybierz: a, b, c, d");
            //string wybor = Console.ReadLine();
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //        if (wybor == "d")
            //            if ((i == 0 || i == x - 1) || (j == 0 || j == x - 1))
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        else if (wybor == "a")
            //        {
            //            if (i + 1 > j)
            //                Console.Write("*");
            //        }
            //        else if (wybor == "b")
            //        {
            //            if (j + 1 > i)
            //                Console.Write("*");
            //        }
            //        else if (wybor == "c")
            //        {
            //            if (j  < i)
            //                Console.Write(" ");
            //            else
            //                Console.Write("*");
            //        }
            //    Console.WriteLine();
            //}
            /*Zadanie 3.10.
Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.*/
            //Console.WriteLine("Podaj n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int silnia = 1;
            //for (int i = 1; i <= n; i++)
            //    silnia *= i;
            //Console.WriteLine("Silnia z {0}! = {1}", n, silnia);
            /*Zadanie 3.11. 
Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 
1) należy dodać do siebie, aby suma przekroczyła wartość 100.*/
            //int ile = 0;
            //int suma = 1;
            //for (int i = 1; suma < 100; ile++, i++)
            //{
            //    Console.WriteLine("{0}: suma={1}", ile, suma);
            //    suma += i;
            //}
            //Console.WriteLine("Aby osiagnac 100 od 1 potrzeba {0} iteracji.", ile);
            /*Zadanie 3.12. 
Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te 
liczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero). Wynikiem działania programu 
ma być informacja o sumie wprowadzonych przez użytkownika liczb.*/
            //int suma = 0;
            //int x;
            //do
            //{
            //    Console.WriteLine("Podaj liczbe calkowita: ");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    suma += x;
            //} while (x != 0);
            //Console.WriteLine("Suma wprowadzonych liczb to: {0}", suma);
            /*Zadanie 3.13. 
Napisz program obliczający sumę szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest 
dowolną liczbą naturalną, którą program ma wczytać*/
            //Console.WriteLine("Podaj liczbe naturalna: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int suma = 0;
            //for(int i = 1; i <= n; i++)
            //{
            //    suma += (i % 2 == 0 ? -i : i);
            //}
            //Console.WriteLine("W({0})={1}", n, suma);
            /*Zadanie 3.14.
Liczba N jest doskonała, gdy jest równa sumie swych podzielników mniejszych od niej 
samej np. 6=1+2+3=6 – jest liczbą doskonałą. Napisz program znajdujący liczby doskonałe w 
przedziale <1,n>, gdzie n podaje użytkownik.*/
            //Console.WriteLine("Podaj liczbe calkowita");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int suma_dzielnikow = 0;
            //for (int i = 1; i < x; i++)
            //{
            //    if (x % i == 0)
            //        suma_dzielnikow += i;
            //}
            //if (suma_dzielnikow == x)
            //    Console.WriteLine("Liczba {0} jest doskonala");
            //else
            //    Console.WriteLine("Liczba {0} nie jest doskonala");
            /*Zadanie 3.15. 
Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów można 
wypłacić 10 zł. Napisz program, który wyświetli w oknie konsoli wszystkie możliwe 
kombinacje.
*/
            int x = 1, y = 2, z = 5;
            int suma=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(1 + " +");
                suma += 1;
            }
            Console.WriteLine(" suma={0}", suma);
        }
    }
}
