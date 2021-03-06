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
            Napisz program, kt??ry pozwoli zape??ni?? n???elementow?? tablic?? jednowymiarow?? liczb
            ca??kowitych warto??ciami podanymi przez u??ytkownika. Na pocz??tku dzia??ania programu
            u??ytkownik podaje liczb?? element??w tablicy, a nast??pnie poszczeg??lne warto??ci jej
            element??w. Po wype??nieniu ca??ej tablicy program powinien wypisa?? je w oknie konsoli.
            */
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj liczbe element??w w tablicy");
            int LiczbaElementow = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = new int[LiczbaElementow];
            for (int i = 0; i < LiczbaElementow; i++)
                tab1[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zad1(tab1));
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();

            /*Zadanie 4.2.
            Napisz program kopiuj??cy z danej tablicy liczb ca??kowitych tab1 do nowej tablicy tab2
            wy????cznie warto??ci dodatnie. Obie tablice maj?? by?? jednowymiarowe o rozmiarze r??wnym 10
            (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) nale??y wpisa?? w trakcie deklaracji
            tej tablicy.*/
            Console.WriteLine("Zadanie 2");
            int[] tab2 = new int[10] { 0, -1, 2, 3, 4, 5, -6, 7, 8, 9 };
            int[] output2 = zad2(tab2);
            Console.WriteLine("Tablica wej??ciowa:");
            foreach (int x in tab2)
                Console.Write("{0, 3}", x);
            Console.WriteLine("\nTablica wyj??ciowa:");
            foreach (int x in output2)
                Console.Write("{0, 3}", x);
            Console.WriteLine("\nWci??nij enter");
            Console.ReadKey();

            /*
                Zadanie 4.3.
            Napisz program wy??wietlaj??cy informacje o wype??nionej przez u??ytkownika tablicy nelementowej:
            ??? warto???? i numer pozycji najwi??kszego elementu,
            ??? warto???? i numer pozycji najmniejszego elementu,
            ??? ??rednia warto??ci wszystkich element??w tablicy,
            ??? liczba dodatnich element??w tablicy.*/
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

            Console.WriteLine("Warto????={0}, Index={1} najwi??kszego elementu", zad3_max, max_index);


            Console.WriteLine("Warto????={0}, Index={1} najmniejszego elementu", zad3_min, min_index);

            float srednia = (float)suma / tab1.Length;
            Console.WriteLine("??rednia warto???? wszystkich element??w tablicy={0}", srednia);
            Console.WriteLine("Liczba dodatnich element??w w tablicy={0}", liczbaDodatnich);

            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
             * Zadanie 4.4.
            Napisz program, kt??ry podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
            int. Tablic?? nale??y wype??ni?? losowymi warto??ciami. Wskaz??wka: Poni??szy fragment
            programu pokazuje dzia??anie klasy Random (kt??ra zawiera generator liczb pseudolosowych) ???
            w p??tli zostanie wy??wietlonych 100 liczb wybranych losowo z zakresu 1 ??? 999 (o zakresie
            decyduj?? argumenty podane w wywo??aniu metody Next()43).
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
            Console.WriteLine("W??r??d wygenerowanych liczb jest {0} liczb pierwszych", ilePierwszych);
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            Zadanie 4.5.
            Dana jest n-elementowa tablica liczb ca??kowitych tab1. Napisz program kopiuj??cy
            warto??ci element??w tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesuni??ciem o
            jedn?? pozycje. To znaczy, ??e element w tablicy ??r??d??owej o indeksie 0 powinien znale???? si?? w
            tablicy docelowej pod indeksem 1, element o indeksie 1 ma by?? w tablicy docelowej pod
            indeksem 2 itd. Element ostatni tablicy ??r??d??owej ma by?? elementem o indeksie 0 w tablicy
            docelowej.
            */
            int[] tab5 = new int[7] { -9, 0, 1, 4, 2, 3, 5 };
            Console.WriteLine("Przed przesuni??ciem");
            foreach (int x in tab5)
                Console.Write("{0,3}", x);
            Console.WriteLine("\nPo przesuni??ciem");
            foreach (int x in przesuniecieIndexPrawo(tab5))
                Console.Write("{0,3}", x);

            Console.WriteLine("\nWci??nij enter");
            Console.ReadKey();
            /*
            Zadanie 4.6.
            Napisz program, kt??ry deklaruje i inicjalizuje dwuwymiarow?? tablic?? liczb
            rzeczywistych o rozmiarze 5 x 5. Program ma wy??wietli?? elementy tablicy (wiersz po
            wierszu), a nast??pnie wy??wietli?? sum?? element??w znajduj??cych si?? na g????wnej przek??tnej
            tablicy (g????wna przek??tna ??? od elementu o indeksach 0,0 do elementu o indeksach n,n).
            */
            int[,] macierz6 = new int[5, 5];
            for (int i = 0; i < macierz6.GetLength(0); i++)
                for (int j = 0; j < macierz6.GetLength(1); j++)
                    macierz6[i, j] = rand.Next(1, 5);
            wypiszMatrix(macierz6);
            Console.WriteLine("Suma warto??ci element??w na g????wnej przek??tnej to:{0}", sumaPrzekatna(macierz6));
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            Zadanie 4.7.
            Napisz program, kt??ry dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy
            nale??y umie??ci?? w tablicach dwuwymiarowych w trakcie deklaracji. Program ma wy??wietli??
            macierz wynikow??. Wskaz??wka: Dodawanie macierzy ??? macierz wynikowa C zawiera
            elementy, kt??re stanowi?? sum?? element??w macierzy A i B o odpowiednich indeksach, tzn.
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

            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            Zadanie 4.8.
            Uzupe??nij poni??szy kod programu o wszystkie dni tygodnia i przy u??yciu p??tli wy??wietl
            zawarto???? tablicy: w ka??dym wierszu dany dzie?? tygodnia w trzech j??zykach (polskim,
            angielskim, niemieckim).
            string[,] dniTygodnia;
            dniTygodnia = new string[2, 3]; // pami??taj o zmianie rozmiaru tablicy
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

            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            * Zadanie 4.9.
            Napisz program obliczaj??cy liczb?? wyraz??w w ??a??cuchu znak??w wprowadzonym przez
            u??ytkownika. Nale??y przyj????, ??e wyrazy to ci??gi znak??w rozdzielone spacj??.
            */
            Console.WriteLine("Podaj dowolne zdanie: ");
            string zdanie9 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Liczba s????w w twoim zdaniu: {0}", zdanie9.Split(' ').Length);
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            Zadanie 4.10.
            Napisa?? program, kt??ry pobierze dat?? w formacie DD-MM-RRRR, z kt??rej pobierze
            miesi??c i wy??wietli jego nazw?? s??ownie. 
            */
            string[] data = {"Styczen", "Luty", "Marzec", "Kwiecie??",
                              "Maj", "Czerwiec", "Lipiec", "Sierpie??",
                              "Wrzesie??", "Pa??dziernik", "Listopad", "Grudzie??"};
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            string data_numeric = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Twoj miesi??c to: {0}", data[outData(data_numeric) - 1]);
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
            zadanie 4.11.
            napisz program analizuj??cy cz??sto???? wyst??powania poszczeg??lnych znak??w w
            ??a??cuchu znak??w wprowadzonym przez u??ytkownika. np. dla wprowadzonego tekstu
            ???abrakadabra??? program powinien wy??wietli?? informacje: a ??? 5, b ??? 2, r ??? 2, k ??? 1, d ??? 1.
            */

            dictionary<char, int> mapowanieliter = new dictionary<char, int>();
            console.writeline("podaj ciag znak??w");
            string ciagznakow = console.readline();
            console.writeline("twoj ciag znakow to: {0}", ciagznakow);
            foreach (char el in ciagznakow)
                if (mapowanieliter.containskey(el))
                    mapowanieliter[el] += 1;
                else
                    mapowanieliter[el] = 1;

            foreach (keyvaluepair<char, int> literka in mapowanieliter)
                console.writeline("literka:{0}, liczba wyst??pie??:{1}", literka.key, literka.value);
            console.writeline("wci??nij enter");
            console.readkey();
            /*
            Zadanie 4.12.
            Napisz program, kt??ry dla zadeklarowanej ni??ej zmiennej ??a??cuchowej wy??wietli jej
            zawarto????, poda liczb?? wierszy oraz poda liczb?? znak??w w ka??dym wierszu.
             fragment powie??ci A. A. Milne, "Kubu?? Puchatek"
            string tekst = "W par?? godzin p????niej, gdy noc zbiera??a si?? do odej??cia,\n" +
            "Puchatek obudzi?? si?? nagle z uczuciem dziwnego przygn??bienia.\n" +
            "To uczucie dziwnego przygn??bienia miewa?? ju?? nieraz i wiedzia??,\n" +
            "co ono oznacza. By?? g??odny. Wi??c poszed?? do spi??arni,\n" +
            "wgramoli?? si?? na krzese??ko, si??gn???? na g??rn?? p????k??, ale nic nie znalaz??.";
            */
            string tekst = "W par?? godzin p????niej, gdy noc zbiera??a si?? do odej??cia,\n" +
            "Puchatek obudzi?? si?? nagle z uczuciem dziwnego przygn??bienia.\n" +
            "To uczucie dziwnego przygn??bienia miewa?? ju?? nieraz i wiedzia??,\n" +
            "co ono oznacza. By?? g??odny. Wi??c poszed?? do spi??arni,\n" +
            "wgramoli?? si?? na krzese??ko, si??gn???? na g??rn?? p????k??, ale nic nie znalaz??.";
            Console.WriteLine("Zawartosc zmiennej to fragment powie??ci A. A. Milne, \"Kubu?? Puchatek\"\n{0}\n", tekst);
            Console.WriteLine("Liczba wierszy: {0}", tekst.Split('\n').Length);
            int licznikWierszy = 0;
            foreach (var el in tekst.Split('\n'))
                Console.WriteLine("Wiersz:{0}, liczba znak??w:{1}", licznikWierszy++, el.Length);
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();

            /*
            Zadanie 4.13.
            Napisz program, kt??ry przeanalizuje dany ??a??cuch pod k??tem wielokrotnego
            wyst??powania s????w w tek??cie. Przyk??adowo dla zmiennej ??a??cuchowej o zawarto??ci: ???Kiedy
            idzie si?? po mi??d z balonikiem, to trzeba si?? stara??, ??eby pszczo??y nie wiedzia??y, po co si??
            idzie ??? odpowiedzia?? Puchatek??? ??? program powinien wypisa?? raport o s??owach powielonych
            w tym tek??cie: idzie ??? 2 razy, po ??? 2 razy, si?? ??? 3 razy. 
            */
            Dictionary<string, int> mappowanieSlow = new Dictionary<string, int>();
            string nazwa = @"Kiedy idzie si?? po mi??d z balonikiem, to trzeba si?? stara??,
            ??eby pszczo??y nie wiedzia??y, po co si?? idzie ??? odpowiedzia?? Puchatek";
            char[] Delimeters = { ',', ' ' };
            foreach (string slowo in nazwa.Split(' '))
                if (slowo != "")
                    if (mappowanieSlow.ContainsKey(slowo))
                        mappowanieSlow[slowo] += 1;
                    else
                        mappowanieSlow[slowo] = 1;
            foreach (KeyValuePair<string, int> slowo in mappowanieSlow)
                if (slowo.Value > 1)
                    Console.WriteLine("Slowo: >{0}<, Ilo????: {1}", slowo.Key, slowo.Value);
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*
             Zadanie 4.14.
            W danej firmie ??rodki trwa??e maj?? identyfikatory z??o??one z kilku liter, my??lnika oraz
            czterech cyfr. Te cztery cyfry to rok zakupu danego ??rodka trwa??ego. Przyk??adowe
            identyfikatory to: KOMG-2002, BH-2010. Napisz program, kt??ry deklaruje 5-cio elementow??
            tablic?? typu string dla ??rodk??w trwa??ych, kt??r?? nale??y zainicjalizowa?? przyk??adowymi
            identyfikatorami w czasie deklaracji. Program ma dla ka??dego ??rodka trwa??ego poda?? liczb??
            lat, jakie up??yn????y od jego zakupu
             */
            string[] identyfikatory = new string[5] { "KG-2004", "AM-2010", "OOP-2000", "TE-2009", "OK-1999" };
            foreach (string id in identyfikatory)
                Console.WriteLine("Identyfikator: {0,9}, Ile lat mine??o: {1,4}", id, 2021 - Convert.ToInt32(id.Split('-')[1]));
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
            /*Zadanie 4.15.
            Napisz program, kt??ry szyfruje podany przez u??ytkownika tekst prostym szyfrem
            podstawieniowym zwanym ???gaderypoluki???. Nazwa pochodzi od jednego z najcz????ciej
            u??ywanych kluczy GA-DE-RY-PO-LU-KI. Klucz ten zawiera pary znakowych zamiennik??w
            umieszczonych mi??dzy my??lnikami. Litery, kt??rych nie ma w kluczu pozostawia si?? w
            szyfrowanym tek??cie bez zmian. Przyk??adowo tekst ???DRZEWO??? po zaszyfrowaniu ma posta??
            ???EYZDWP???.
            0 1 2 3 4 5 6 7 8 9 10 11
            G A D E R Y P O L U K I
            Wskaz??wki: Mo??na zastosowa?? w programie klucz z pomini??ciem my??lnik??w (GADERYPOLUKI).
            W??wczas mo??na przyj????, ??e znaki na parzystych pozycjach (numeruj??c od 0) maj?? zamiennik po
            prawej stronie, a znaki na nieparzystych pozycjach maj?? sw??j zamiennik z lewej strony (np. litera O
            jest na pozycji numer 7 i ma sw??j zamiennik z lewej strony, czyli P). Zostaje zatem sprawdzenie, czy
            dany znak szyfrowanego tekstu wyst??puje w kluczu, a je??li tak to, na kt??rej pozycji klucza ??? parzystej
            czy nieparzystej. W tym celu mo??esz wykorzysta?? poznan?? w tym rozdziale metod?? IndexOf(). Dla
            zaszyfrowanego tekstu najlepiej b??dzie zadeklarowa?? now?? zmienn?? ??a??cuchow?? i zainicjalizowa?? j??
            warto??ci?? pust??. Zalecamy, aby zrobi?? to przy pomocy statycznego pola publicznego String.Empty
            zawieraj??cego ??a??cuch pusty (czyli ""), np.: string tekstZaszyfrowany = String.Empty;. A
            nast??pnie w p??tli dodawa?? kolejny znak z tekstu ??r??d??owego ??? ten sam lub zamieniony zgodnie z
            kluczem (je??li jest w kluczu). */
            string testowy = "DRZEWO";
            Console.WriteLine("Twoje slowo to: {0}, po zaszyfrowaniu: {1}", testowy, szyfruj(testowy));
            Console.WriteLine("Wci??nij enter");
            Console.ReadKey();
        }
    }
}
