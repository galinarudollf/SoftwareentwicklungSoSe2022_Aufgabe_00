using System;
using System.Globalization;

namespace Aufgaben00
{
   enum Kategorie{A,B,C};
    class A2
    {
        static void Main(string[] args)
        {
            string bezeichnung="007";
            int regnummer=7;
            //char kategorie='A';
            Kategorie kategorie=Kategorie.A;
            double leuchtkraft=20.30;

            try{
                Int32.Parse("XYZ");
                //Console.WriteLine(args.Length);
                //bezeichnung=args[0];
                //regnummer=Int32.Parse(args[1]);
                //kategorie=Char.Parse(args[2]);
                //leuchtkraft=Double.Parse(args[3],CultureInfo.InvariantCulture);

                bezeichnung=Console.ReadLine();
                regnummer=Int32.Parse(Console.ReadLine());
                //kategorie=Char.Parse(Console.ReadLine());
                kategorie=Enum.Parse<Kategorie>(Console.ReadLine());
                leuchtkraft=Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                }
            catch(FormatException){
                Console.WriteLine("Falsches Format");
            }
            catch(OverflowException){
                Console.WriteLine("Überschreitung des Wertebereicht");
            }

            //Console.WriteLine(bezeichnung);
            Console.WriteLine($"Bezeichnung {bezeichnung}");
            Console.WriteLine("Bezeichnug {0,10}", bezeichnung);
            //Console.WriteLine(regnummer);
            Console.WriteLine("Regnummer {0}",regnummer);
            Console.WriteLine("Regnummer {0:d}",regnummer);
            //Console.WriteLine(kategorie);
            Console.WriteLine("Kategorie "+kategorie);
            CultureInfo myCIintl = new CultureInfo("en-US", false);
            Console.WriteLine(leuchtkraft.ToString(myCIintl));
            //Console.WriteLine(leuchtkraft.ToString(CultureInfo.InvariantCulture));//kultur unabhängig
        }
    }
}
