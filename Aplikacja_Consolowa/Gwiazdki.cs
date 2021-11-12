using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe5_6
{

    class Gwiazdki
    {
        private string wybor;
        private double x;
        public string set_wybor
        {
            set { wybor = value; }
            get { return wybor; }
        }
        public double set_x
        {
            set { x = value; }
            get { return x; }
        }

        public void rysuj()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                    if (wybor == "d")
                        if ((i == 0 || i == x - 1) || (j == 0 || j == x - 1))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    else if (wybor == "a")
                    {
                        if (i + 1 > j)
                            Console.Write("*");
                    }
                    else if (wybor == "b")
                    {
                        if (j + 1 > i)
                            Console.Write("*");
                    }
                    else if (wybor == "c")
                    {
                        if (j < i)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                Console.WriteLine();
            }
        }
    }
}
