using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str =
            "Vänligen välj ett alternativ\n" + 
            "1. Beräkna Ampere\n" + 
            "2.  Beräkna Resistans\n" + 
            "3.  Beräkna Diameter\n" + 
            "4.  Beräkna Radie\n" + 
            "5.  Beräkna Restid\n" + 
            "6.  Beräkna Förflyttning\n" + 
            "7.  Beräkna Hastighet\n" + 
            "8.  Beräkna Spänning\n" + 
            "9.  Konvertera Celcius till Fahrenheit\n" + 
            "10. Konvertera Fahrenheit till Celcius\n" + 
            "11.  Konvertera Gallon till Liter\n" + 
            "12.  Konvertera Liter till Gallon\n" + 
            "13.  Konvertera Timmar till Minuter\n" + 
            "14.  Konvertera Minuter till Timmar" + 
            ""; 
            
            ConverterService converter = new ConverterService();
            //Start point for the program.
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
