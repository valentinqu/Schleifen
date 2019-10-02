using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            // //for(Variable, Bedingung, Schritte)
            //// for (int i = 10; i>=20; i++)
            // //{
            //   //  Console.WriteLine("Durchlauf {0}", i);
            // //}
            // //while Schleife
            // //while(Bedingung)
            // int a = 1;
            // while (a < 32)
            // {
            //     a = a * 2;
            //     Console.WriteLine(a);
            // }

            // //do while Schleife

            // //do Befehle while (Bedingung)
            // int b = 1;
            // do
            // {
            //     b = b * 2;
            //     Console.WriteLine(b);
            // }
            // while (b < 32);


            int a, b, r;
            Console.WriteLine("Der ggT von zwei ganzen Zahlen soll berechnet werden");
            Console.WriteLine("Erste Zahl eingeben");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl eingeben");
            b = Convert.ToInt32(Console.ReadLine());
            int Ergebnis_ggT = ggT(a, b);
            int Ergebnis_kgV = kgV(a, b);
            Console.WriteLine("Der ggT von {1} und {2} ist: {0}", Ergebnis_ggT, a, b);
            Console.WriteLine("Der kgV von {1} und {2} ist: {0}", Ergebnis_kgV, a, b);


            r = 1;
            while(r !=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Der ggT ist:{0}",a);
        }

        static int ggT(int a0, int b0)
        {
            int r = 1;
            while (r != 0)
            {
                r = a0 % b0;
                a0 = b0;
                b0 = r;
            }
            return a0;
        }
            static int kgV(int a1, int b1)
            {
            int r = 1;
            int c, d;
            c = a1; d = b1;
            while(r != 0)
            {
                r = a1 % b1;
                a1 = b1;
                b1 = r;
                   

            }
            return c * d / a1;
             
            }
        }
}

