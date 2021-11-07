using System;
using System.Collections.Generic;

namespace ProgramowanieObiektowe
{
    public class Program
    {
        public static string zad1(int[] tab)
        {
            string output = "";
            foreach (int x in tab)
                output = String.Concat(Convert.ToString(x)+" ", output);
            return output;
        }

        public static int [] zad2(int [] tab)
        {
            int[] output = new int[10];
            int i = 0;
            foreach (int x in tab)
                if (x > 0)
                    output[i++] = x;
            return output;
        }
        public static bool jestPierwsza(int a)
        {
            if (a == 0 || a == 1 || a == 2)
                return false;
            for (int i = 3; i < a; i++)
            {
                if (a % 2 == 0)
                    return false;
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        public static int[] przesuniecieIndexPrawo(int [] tab)
        {
            int[] output = new int[tab.Length];
            for(int i = 0; i < tab.Length; i++)
            {
                if (i == (tab.Length - 1))
                    output[0] = tab[tab.Length - 1];
                else
                   output[i + 1] = tab[i];
            }
            return output;
        }
        public static void wypiszMatrix(int [,] matrix)
        {
            Console.WriteLine("Wypisuje Macierz");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,2}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int [,] dodajMatrix(int [,]matrix1, int[,]matrix2)
        {
            int[,] output = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    output[i, j] = matrix1[i, j] + matrix2[i, j];
            return output;
        }
        public static int sumaPrzekatna(int[,] matrix)
        {
            int suma = 0;
            for (int i = 0; i < matrix.GetLength(0);i++)
                suma += matrix[i, i];
            return suma;
        }
        public static int liczbaWyrazow(string zdanie)
        {
            int liczbaWyrazow = 0;
            int wsk = 0;
            while ((wsk = zdanie.IndexOf(' ', wsk + 1))>=0){
                liczbaWyrazow++;
                
            }
            return liczbaWyrazow + 1;
        }
        public static int outData(string data)
        {
            return Convert.ToInt32(data.Split('-')[1]);
        }
        public static string szyfruj(string napis)
        {
            string output = "";
            Dictionary<char, char> mappowanieZnakow = new Dictionary<char, char>();
            string garderypoluki = "GA-DE-RY-PO-LU-KI";
            foreach (var el in garderypoluki.Split('-'))
            {
                mappowanieZnakow[el[0]] = el[1];
                mappowanieZnakow[el[1]] = el[0];
            }
            foreach (char el in napis)
                if (mappowanieZnakow.ContainsKey(el))
                    output += mappowanieZnakow[el];
                else
                    output += el;
            return output;
        }
        public static void Main(string[] args)
        {
            /*
                Zadanie 4.1.
            Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
            całkowitych wartościami podanymi przez użytkownika. Na początku działania programu
            użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
            elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.
            */
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj liczbe elementów w tablicy");
            int LiczbaElementow = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = new int[LiczbaElementow];
            for (int i = 0; i < LiczbaElementow; i++)
                tab1[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zad1(tab1));
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();

            /*Zadanie 4.2.
            Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
            wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10
            (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji
            tej tablicy.*/
            Console.WriteLine("Zadanie 2");
            int[] tab2 = new int[10] { 0, -1, 2, 3, 4, 5, -6, 7, 8, 9 };
            int[] output2 = zad2(tab2);
            Console.WriteLine("Tablica wejściowa:");
            foreach (int x in tab2)
                Console.Write("{0, 3}", x);
            Console.WriteLine("\nTablica wyjściowa:");
            foreach (int x in output2)
                Console.Write("{0, 3}", x);
            Console.WriteLine("\nWciśnij enter");
            Console.ReadKey();

            /*
                Zadanie 4.3.
            Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
             wartość i numer pozycji największego elementu,
             wartość i numer pozycji najmniejszego elementu,
             średnia wartości wszystkich elementów tablicy,
             liczba dodatnich elementów tablicy.*/
            Console.WriteLine("Korzystam z tablicy z zadania 1");

            int zad3_max = tab1[0];
            int max_index = 0;
            int zad3_min = tab1[0];
            int min_index = 0;
            int suma = 0;
            int liczbaDodatnich = 0;

            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > zad3_max)
                {
                    zad3_max = tab1[i];
                    max_index = i;
                }
                if (tab1[i] < zad3_min)
                {
                    zad3_min = tab1[i];
                    min_index = i;
                }
                if (tab1[i] > 0)
                    liczbaDodatnich++;
                suma += tab1[i];
            }

            Console.WriteLine("Wartość={0}, Index={1} największego elementu", zad3_max, max_index);


            Console.WriteLine("Wartość={0}, Index={1} najmniejszego elementu", zad3_min, min_index);

            float srednia = (float)suma / tab1.Length;
            Console.WriteLine("Średnia wartość wszystkich elementów tablicy={0}", srednia);
            Console.WriteLine("Liczba dodatnich elementów w tablicy={0}", liczbaDodatnich);

            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
             * Zadanie 4.4.
            Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
            int. Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment
            programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych) –
            w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie
            decydują argumenty podane w wywołaniu metody Next()43).
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
             Console.Write("{0,8}", rand.Next(1, 1000));
             */
            int Generuj = 20;
            int[] tab4 = new int[20];
            int ilePierwszych = 0;
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                tab4[i] = rand.Next(1, 20);
                Console.Write("{0,4}", tab4[i]);
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
                if (jestPierwsza(tab4[i]))
                    ilePierwszych++;
            }
            Console.WriteLine("Wśród wygenerowanych liczb jest {0} liczb pierwszych", ilePierwszych);
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            Zadanie 4.5.
            Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
            wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o
            jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
            tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
            indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
            docelowej.
            */
            int[] tab5 = new int[7] { -9, 0, 1, 4, 2, 3, 5 };
            Console.WriteLine("Przed przesunięciem");
            foreach (int x in tab5)
                Console.Write("{0,3}", x);
            Console.WriteLine("\nPo przesunięciem");
            foreach (int x in przesuniecieIndexPrawo(tab5))
                Console.Write("{0,3}", x);

            Console.WriteLine("\nWciśnij enter");
            Console.ReadKey();
            /*
            Zadanie 4.6.
            Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
            rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po
            wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej
            tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).
            */
            int[,] macierz6 = new int[5, 5];
            for (int i = 0; i < macierz6.GetLength(0); i++)
                for (int j = 0; j < macierz6.GetLength(1); j++)
                    macierz6[i, j] = rand.Next(1, 5);
            wypiszMatrix(macierz6);
            Console.WriteLine("Suma wartości elementów na głównej przekątnej to:{0}", sumaPrzekatna(macierz6));
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            Zadanie 4.7.
            Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy
            należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. Program ma wyświetlić
            macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera
            elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
            element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o
            tych samych indeksach macierzy B, element A [0,1] do B [0,1]... itd.
            */
            int[,] macierz1 = new int[2, 3];
            int[,] macierz2 = new int[2, 3];
            for (int i = 0; i < macierz1.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.GetLength(1); j++)
                {
                    macierz1[i, j] = rand.Next(0, 4);
                    macierz2[i, j] = rand.Next(4, 7);
                }
            }
            wypiszMatrix(macierz1);
            wypiszMatrix(macierz2);
            int[,] output7;
            output7 = dodajMatrix(macierz1, macierz2);
            wypiszMatrix(output7);

            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            Zadanie 4.8.
            Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
            zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim,
            angielskim, niemieckim).
            string[,] dniTygodnia;
            dniTygodnia = new string[2, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            */
            string[,] dniTygodnia = new string[3, 7] {
                {"Poniedzialek", "Wtorek", "Sroda", "Czwartek", "Piatek", "Sobota", "Niedziela"},
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"},
                {"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"}
            };
            Console.WriteLine("Wypisuje dni tygodnia po Polsku, Angielski, Niemiecku");
            for (int i = 0; i < dniTygodnia.GetLength(1); i++)
            {
                Console.WriteLine("Polski:{0,-10}, Angielski:{1,-10}, Niemiecki: {2,-10}", dniTygodnia[0, i], dniTygodnia[1, i], dniTygodnia[2, i]);
                Console.WriteLine();
            }

            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            * Zadanie 4.9.
            Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
            użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
            */
            Console.WriteLine("Podaj dowolne zdanie: ");
            string zdanie9 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Liczba słów w twoim zdaniu: {0}", zdanie9.Split(' ').Length);
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            Zadanie 4.10.
            Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
            miesiąc i wyświetli jego nazwę słownie. 
            */
            string[] data = {"Styczen", "Luty", "Marzec", "Kwiecień",
                              "Maj", "Czerwiec", "Lipiec", "Sierpień",
                              "Wrzesień", "Październik", "Listopad", "Grudzień"};
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            string data_numeric = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Twoj miesiąc to: {0}", data[outData(data_numeric) - 1]);
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
            zadanie 4.11.
            napisz program analizujący częstość występowania poszczególnych znaków w
            łańcuchu znaków wprowadzonym przez użytkownika. np. dla wprowadzonego tekstu
            „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
            */

            dictionary<char, int> mapowanieliter = new dictionary<char, int>();
            console.writeline("podaj ciag znaków");
            string ciagznakow = console.readline();
            console.writeline("twoj ciag znakow to: {0}", ciagznakow);
            foreach (char el in ciagznakow)
                if (mapowanieliter.containskey(el))
                    mapowanieliter[el] += 1;
                else
                    mapowanieliter[el] = 1;

            foreach (keyvaluepair<char, int> literka in mapowanieliter)
                console.writeline("literka:{0}, liczba wystąpień:{1}", literka.key, literka.value);
            console.writeline("wciśnij enter");
            console.readkey();
            /*
            Zadanie 4.12.
            Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej
            zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
             fragment powieści A. A. Milne, "Kubuś Puchatek"
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            */
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            Console.WriteLine("Zawartosc zmiennej to fragment powieści A. A. Milne, \"Kubuś Puchatek\"\n{0}\n", tekst);
            Console.WriteLine("Liczba wierszy: {0}", tekst.Split('\n').Length);
            int licznikWierszy = 0;
            foreach (var el in tekst.Split('\n'))
                Console.WriteLine("Wiersz:{0}, liczba znaków:{1}", licznikWierszy++, el.Length);
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();

            /*
            Zadanie 4.13.
            Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego
            występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy
            idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się
            idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych
            w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy. 
            */
            Dictionary<string, int> mappowanieSlow = new Dictionary<string, int>();
            string nazwa = @"Kiedy idzie się po miód z balonikiem, to trzeba się starać,
            żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            char[] Delimeters = { ',', ' ' };
            foreach (string slowo in nazwa.Split(' '))
                if (slowo != "")
                    if (mappowanieSlow.ContainsKey(slowo))
                        mappowanieSlow[slowo] += 1;
                    else
                        mappowanieSlow[slowo] = 1;
            foreach (KeyValuePair<string, int> slowo in mappowanieSlow)
                if (slowo.Value > 1)
                    Console.WriteLine("Slowo: >{0}<, Ilość: {1}", slowo.Key, slowo.Value);
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*
             Zadanie 4.14.
            W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz
            czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. Przykładowe
            identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową
            tablicę typu string dla środków trwałych, którą należy zainicjalizować przykładowymi
            identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę
            lat, jakie upłynęły od jego zakupu
             */
            string[] identyfikatory = new string[5] { "KG-2004", "AM-2010", "OOP-2000", "TE-2009", "OK-1999" };
            foreach (string id in identyfikatory)
                Console.WriteLine("Identyfikator: {0,9}, Ile lat mineło: {1,4}", id, 2021 - Convert.ToInt32(id.Split('-')[1]));
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            /*Zadanie 4.15.
            Napisz program, który szyfruje podany przez użytkownika tekst prostym szyfrem
            podstawieniowym zwanym „gaderypoluki”. Nazwa pochodzi od jednego z najczęściej
            używanych kluczy GA-DE-RY-PO-LU-KI. Klucz ten zawiera pary znakowych zamienników
            umieszczonych między myślnikami. Litery, których nie ma w kluczu pozostawia się w
            szyfrowanym tekście bez zmian. Przykładowo tekst „DRZEWO” po zaszyfrowaniu ma postać
            „EYZDWP”.
            0 1 2 3 4 5 6 7 8 9 10 11
            G A D E R Y P O L U K I
            Wskazówki: Można zastosować w programie klucz z pominięciem myślników (GADERYPOLUKI).
            Wówczas można przyjąć, że znaki na parzystych pozycjach (numerując od 0) mają zamiennik po
            prawej stronie, a znaki na nieparzystych pozycjach mają swój zamiennik z lewej strony (np. litera O
            jest na pozycji numer 7 i ma swój zamiennik z lewej strony, czyli P). Zostaje zatem sprawdzenie, czy
            dany znak szyfrowanego tekstu występuje w kluczu, a jeśli tak to, na której pozycji klucza – parzystej
            czy nieparzystej. W tym celu możesz wykorzystać poznaną w tym rozdziale metodę IndexOf(). Dla
            zaszyfrowanego tekstu najlepiej będzie zadeklarować nową zmienną łańcuchową i zainicjalizować ją
            wartością pustą. Zalecamy, aby zrobić to przy pomocy statycznego pola publicznego String.Empty
            zawierającego łańcuch pusty (czyli ""), np.: string tekstZaszyfrowany = String.Empty;. A
            następnie w pętli dodawać kolejny znak z tekstu źródłowego – ten sam lub zamieniony zgodnie z
            kluczem (jeśli jest w kluczu). */
            string testowy = "DRZEWO";
            Console.WriteLine("Twoje slowo to: {0}, po zaszyfrowaniu: {1}", testowy, szyfruj(testowy));
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
        }
    }
}
