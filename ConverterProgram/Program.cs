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

            int val;
            float result;
            while(true){
                Console.WriteLine(str);
                while(!Int32.TryParse(Console.ReadLine(), out val)){
                    Console.WriteLine("Felaktigt val {0}\n" + str, val);
                }
                switch(val){
                    case 1: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateAmps(ReadUserData("Ange spänningen"), ReadUserData("Ange resistansen"));
                    Console.WriteLine("Strömmen blir {0} A", result);
                    Console.ReadLine();
                    break;
                    case 2: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateResistance(ReadUserData ("Ange Spänningen"), ReadUserData("Ange ampere"));
                    Console.WriteLine("Resistansen blir {0} Ohm", result);
                    Console.ReadLine();
                    break;
                    case 3: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateDiameterFromArea(ReadUserData("Ange area"));
                    Console.WriteLine("Diametern blir {0}", result);
                    Console.ReadLine();
                    break;
                    case 4: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateRadiusFromArea(ReadUserData("Ange area"));
                    Console.WriteLine("Radien blir {0}", result);
                    Console.ReadLine();
                    break;
                    case 5: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateTravelTime(ReadUserData("Ange avståndet"), ReadUserData("Ange Hastigheten"));
                    Console.WriteLine("Resetiden blir {0}", result);
                    Console.ReadLine();
                    break;
                    case 6: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateTraveledDistance(ReadUserData("Ange hastigheten"), ReadUserData("Ange tiden"));
                    Console.WriteLine("Avståndet blir {0}", result);
                    Console.ReadLine();
                    break;
                    case 7: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateSpeed(ReadUserData("Ange tiden"), ReadUserData("Ange avståndet"));
                    Console.WriteLine("Hastigheten blir {0}", result);
                    Console.ReadLine();
                    break;
                    case 8: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.CalculateVoltage(ReadUserData("Ange ampere"), ReadUserData("Ange resistans"));
                    Console.WriteLine("Spänningen blir {0} V", result);
                    Console.ReadLine();
                    break;
                    case 9: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.ConvertCelciusToFahrenheit(ReadUserData("Ange Celsius"));
                    Console.WriteLine("Angivet värde blir {0} farhenheit", result);
                    Console.ReadLine();
                    break;
                    case 10: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.ConvertFahrenheitToCelcius(ReadUserData("Ange Fahrenheit"));
                    Console.WriteLine("Angivet värde blir blir {0} celcius", result);
                    Console.ReadLine();
                    break;
                    case 11: 
                    Console.WriteLine("Du valde {0}",val);
                    result = converter.ConvertFromGallonToLiter(ReadUserData("Ange mängden gallon du vill konvertera till liter"));
                    Console.WriteLine("Angivna gallon är {0} liter", result);
                    Console.ReadLine();
                    break;
                    case 12: 
                    Console.WriteLine("{0}",val);
                    result = converter.ConvertFromLiterToGallon(ReadUserData("Ange mängden liter du vill konvertera till gallon"));
                    Console.WriteLine("Angivna liter är {0} gallon", result);
                    Console.ReadLine();
                    break;
                    case 13: 
                    Console.WriteLine("{0}",val);
                    result = converter.ConvertFromHoursToMinutes(ReadUserData("Ange antalet timmar du vill konvertera till minuter"));
                    Console.WriteLine("Angivna timmar blir {0} minuter", result);
                    Console.ReadLine();
                    break;
                    case 14: 
                    Console.WriteLine("{0}",val);
                    result = converter.ConvertFromMinutesToHours(ReadUserData("Ange antalet minuter du vill konvertera till timmar"));
                    Console.WriteLine("Angivna minuter blir {0} timmar", result);
                    Console.ReadLine();
                    break;
                    case 0: return ;
                    default: 
                        Console.WriteLine("Feaktigt val försök igen!");
                        Console.ReadLine();
                    break;


                }
            }
        }
    }
}
