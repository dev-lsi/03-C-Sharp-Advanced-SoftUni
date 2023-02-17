using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car1= new Car();

            car1.Make = "bmw";
            car1.Model = "30.5";
            car1.Year = 2001;

            Console.WriteLine($"Make: {car1.Make}\nModel: {car1.Model}\nYear: {car1.Year}");

        }
    }
}
