using System;

namespace Service
{
    public class ConverterService : IConverterService
    {
        public ConverterService()
        {
        }

        // 1 gallon = 3.78541178 liters     
        // 1 liter = 0.264172052 gallons   
        //Fahrenheit = Celsius * 9/5 + 32
        //Time = distance / speed
        //Ohm law says: amp = voltage / resistance
        //Radius = square root (area / pi)
        //Diameter = radius * 2

        public float CalculateAmps(float voltage, float resistance)
        {
             return voltage / resistance;
        }
        public float CalculateResistance(float voltage, float amps)
        {
            return voltage / amps;
        }

        public float CalculateDiameterFromArea(float area)
        {
            return  CalculateRadiusFromArea(area)*2;
        }

        public float CalculateRadiusFromArea(float area)
        {
            return (float)Math.Sqrt(area / (float)Math.PI);
        }
        public float CalculateTravelTime(float speed, float distance)
        {
            return distance / speed;
        }
        public float CalculateTraveledDistance(float speed, float time) {
            return speed * time;
        }
        //lol
        public float CalculateSpeed(float time, float distance) {
            return distance / time;
        }

        public float CalculateVoltage(float res, float amp)
        {
            return amp * res;
        }
        
        public float ConvertCelciusToFahrenheit(float celcius)
        {
            return celcius * 9/5 + 32;
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            return gallon * 3.78541178f;
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            return liter * 0.264172052f;
        }

        public float ConvertFromHoursToMinutes(float hours)
        {
            return hours * 60;
        }

        public float ConvertFromMinutesToHours(float minutes)
        {
            return minutes / 60;
        }

        //lol
    }
}
