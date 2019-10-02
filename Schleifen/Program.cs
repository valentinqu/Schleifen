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


            r = 1;
            while(r !=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Der ggT ist:{0}",a);
        }
    }
}
