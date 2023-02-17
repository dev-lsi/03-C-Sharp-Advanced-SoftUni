using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car1= new Car();

            car1.Make = "Mercedes";
            car1.Year = 2006;
            car1.Model="100 S";
            car1.FuelConsumption = 0.12;//per km
            car1.FuelQuantity = 90;

            car1.Drive(200);
            Console.WriteLine("200 km passed");
            Console.WriteLine($" fuel left: {car1.FuelQuantity}");

            Console.WriteLine(car1.WhoAmI());

            car1.Drive(2000);
            

            
        }
    }
}
