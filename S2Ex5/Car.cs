using System.Collections.Generic;

namespace S2Ex5
{
    public class Car
    {
        public string Color { get; set; }
        public int EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }

        public override string ToString()
        {
            return $"Color: {Color} Engine size: {EngineSize} Fuel economy: {FuelEconomy} Is manual shift: {IsManualShift}";
        }

        public List<Car> WhatColor(List<Car> cars, string color)
        {
            List<Car> colorCars = cars.FindAll(car => car.Color.Equals(color));
          

            return colorCars;
        }
    }
}