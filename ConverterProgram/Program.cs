using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static float ReadUserData(string Message){
            float output = 0;
            Console.WriteLine(Message);
            while(!float.TryParse(Console.ReadLine(), out output)){
                Console.WriteLine(Message);
            }
            return output;
        }
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
            "14.  Konvertera Minuter till Timmar\n" + 
            "0. Avsluta"; 
            
            ConverterService converter = new ConverterService();
            //Start point for the program.
            Console.WriteLine(str);
            int val;
            float userinput1;
            float userinput2, result;
            while(true){
                while(!Int32.TryParse(Console.ReadLine(), out val)){
                    Console.WriteLine("Felaktigt val {0}\n" + str, val);
                }
                switch(val){
                    case 1: 
                    Console.WriteLine("Du valde {0}",val);
                    Console.WriteLine("Ange spänningen");
                    float.TryParse(Console.ReadLine(), out userinput1);
                    Console.WriteLine("Ange Resistansen");
                    float.TryParse(Console.ReadLine(), out userinput2);
                    float CalculatedAmps = converter.CalculateAmps(userinput1, userinput2);
                    Console.WriteLine("Strömmen blir {0}", CalculatedAmps);
                    break;
                    case 2: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateResistance(ReadUserData ("Ange Spänningen"), ReadUserData("Ange ampere"));
                    Console.WriteLine("Resistansen blir {0}", result);
                    break;
                    case 3: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateDiameterFromArea(ReadUserData("Ange area"));
                    Console.WriteLine("Diametern blir {0}", result);
                    break;
                    case 4: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 5: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 6: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 7: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 8: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 9: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 10: 
                    Console.WriteLine("Du valde {0}",val);
                    break;
                    case 11: 
                    Console.WriteLine("Du valde {0}",val);
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
