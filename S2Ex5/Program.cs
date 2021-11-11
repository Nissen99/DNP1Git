using System;
using System.Collections.Generic;

namespace S2Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() {Color = "Green", EngineSize = 3, FuelEconomy = 90.3, IsManualShift = false};
            Car car2 = new Car() {Color = "Red", EngineSize = 36, FuelEconomy = 9.3, IsManualShift = true};
            Car car3 = new Car() {Color = "White", EngineSize = 8, FuelEconomy = 901.3, IsManualShift = false};
            Car car4 = new Car() {Color = "Green", EngineSize = 7, FuelEconomy = 9220.3, IsManualShift = true};

       
            List<Car> cars = new List<Car>();
            cars.Add(car);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            List<Car> cars2 = car.WhatColor(cars,"Green");
            foreach (Car car1 in cars2)
            {
                Console.WriteLine(car1);
            }
        }
    }
}