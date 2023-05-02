//Ausgabe:
Console.WriteLine

//Eingabe:
Console.ReadLine

//String:

String str = Console.ReadLine();
Console.WriteLine(str);
Console.WriteLine("Zeichenkette " + str);
Console.WriteLine("Zeichenkette {0}", str);
Console.WriteLine("Zeichenkette {0,10}", str);
Console.WriteLine($"Zeichenkette {str,10}");

//alles andere für die Eingabe Convertierung nötig:
//Möglichkeiten:

//1.
//Klasse Convert: ToInt32, ToChar, ToDouble
//2.
//Methode Parse und TryParse
int iWert = Convert.ToInt32(Console.ReadLine());
//iWert = Int32.Parse(Console.ReadLine());
//Int32.TryParse(Console.ReadLine(),out iWert);

Console.WriteLine("Int Wert "+iWert);
Console.WriteLine("Int Wert {0}",iWert);
Console.WriteLine("Int Wert {0,10}",iWert);
Console.WriteLine($"Int Wert {iWert,10}");

//double:
//Eingabe

using System.Globalization;
double  doWert = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
//der Name der Kultur, das Schriftsystem, der verwendete Kalender, 
//die Sortierreihenfolge von Zeichenfolgen und die Formatierung für Datumsangaben und Zahlen.
//InvariantCulture - Kultur unabhängig

// Ausgabe allgemein: {PlatzhalterID[,Breite][:Format[Stellen]]} , z. B. {0,10:F2}
// Formate:
            // d: dezimal (default)
            // e: Gleitkomma
            // f: Fixpunkt-Format
            // g: generell
            // n: Nummernformat, mit Tausender-Trennzeichen
            // x: hexadezimal
			
Console.WriteLine("Double Wert {0,10:F2}", douWert); //mit ,
Console.WriteLine("Double Wert {0,10}", douWert.ToString("F2",CultureInfo.InvariantCulture)); //mit .

//Ausdrücke:

//Division:
int erg1 = 1 / 2;
Console.WriteLine("{0} ", erg1);
double erg2 = 1 / 2;
Console.WriteLine("{0} ", erg2);
double erg3 = 1f / 2.0;
Console.WriteLine(erg3.ToString("F2", CultureInfo.InvariantCulture));

//Math.Sqrt(...)
//Math.

bool ergebnis;

try
{
   //eingabe
   ergebnis = x >= x1 && x <= x2;
   Console.WriteLine(ergebnis);
}
catch (FormatException)
{
   Console.WriteLine("Falsches Format");
}
catch (OverflowException)
{
   Console.WriteLine("Überschreitung des Wertebereichs");
}

//Bit- und Shift-Operatoren
int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
Console.WriteLine("{0:X}",x & y & z );
Console.WriteLine("{0:X}",(x | y) & z);
Console.WriteLine("{0:X}", ~(x ^ y));
Console.WriteLine("{0:X}", ~(x ^ y) & byte.MaxValue);
Console.WriteLine(x << 3==y);
/*
Exception:
Convert.ToDouble
-> FormatException
-> OverflowException

Double.Parse:
-> ArgumentNullException
-> ArgumentException
-> FormatException
-> OverflowException
*/
