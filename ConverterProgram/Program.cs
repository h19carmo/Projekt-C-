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
            "0. Avsluta"; 
            
            ConverterService converter = new ConverterService();
            //Start point for the program.
            Console.WriteLine(str);
            int val = 0;
            while(true){
                while(!Int32.TryParse(Console.ReadLine(), out val)){
                    Console.WriteLine("Felaktigt val\n" + str);
                }
                switch(val){
                    case 1: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 2: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 3: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 4: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 5: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 6: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 7: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 8: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 9: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 10: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 11: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 12: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 13: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 14: 
                    Console.WriteLine("{0}",val);
                    break;
                    case 0: return ;


                }
            }
        }
    }
}
