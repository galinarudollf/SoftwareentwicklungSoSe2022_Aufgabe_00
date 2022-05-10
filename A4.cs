using System;
using System.Globalization;

namespace Aufgaben00
{
    class A4
    {
        static void Main(string[] args)
        {
            /*
            //arithmetische
            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0;
            int d;
            double f,A;
            d=a/b;
            Console.WriteLine("d={0}", d);
            f=a*b/(c-y)*a/Convert.ToDouble(b,CultureInfo.InvariantCulture);
            Console.WriteLine("f={0}", f);
            f=-b*Math.Sqrt(b*b-4*a*c)/2/a;//NaN- not a number, erg. nicht def. u.a. bei div. null durch null
            //
            Console.WriteLine("f={0}", f);
            A=Math.PI*r*r;
            Console.WriteLine("A={0}", A);
            */
            /*
            //boolsche und vergleich
            double x1, y1, x2, y2, x, y;
            bool ergebnis;

            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ergebnis = x >= x1 && x <= x2;
            Console.WriteLine(ergebnis);

            ergebnis = x >= x1 && x <= x2 && y >= y1 && y <= y2;
            Console.WriteLine(ergebnis);

            ergebnis = x >= x1 && x <= x2 || y >= y1 && y <= y2;
            Console.WriteLine(ergebnis);
            */
            
            //bit und shift
            int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
            Console.WriteLine("{0:X}",x & y & z );
            Console.WriteLine(Convert.ToString(x & y & z,2));
            Console.WriteLine("{0:X}",(x | y) & z);
            Console.WriteLine(Convert.ToString((x | y) & z,2));
            Console.WriteLine("{0:X}", ~(x ^ y));
            Console.WriteLine(Convert.ToString( ~(x ^ y),2));
            Console.WriteLine("{0:X}", ~(x ^ y) & byte.MaxValue);
            Console.WriteLine(Convert.ToString( ~(x ^ y)& byte.MaxValue,2));
            Console.WriteLine(x << 3==y);
        }
    }
}
