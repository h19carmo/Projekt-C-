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
            return Diameter * 2 ;
        }

        public float CalculateRadiusFromArea(float area)
        {
            return area / pi;
        }
        public float CalculateTravelTime(float speed, float distance)
        {
            return speed * distance;
        }
        public float CalculateTraveledDistance(float speed, float time) {
            return speed * time;
        }
        public float CalculateSpeed(float time, float distance) {
            return time * distance;
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
            throw new NotImplementedException();
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromHoursToMinutes(float hours)
        {
            throw new NotImplementedException();
        }

        public float ConvertFromMinutesToHours(float minutes)
        {
            throw new NotImplementedException();
        }
    }
}