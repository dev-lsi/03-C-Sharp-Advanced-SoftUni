using System;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double FuelQuantity 
        { 
            get { return fuelQuantity; }
            set { fuelQuantity = value; } 
        }
        public double FuelConsumption 
        { 
            get { return fuelConsumption; } 
            set { fuelConsumption = value; } 
        }

        public void Drive(double distance)
        {
            if(fuelQuantity - distance* fuelConsumption<0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                this.fuelQuantity = this.fuelQuantity - distance * this.fuelConsumption;
            }

        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\r\n Model: {this.Model}\r\n Year: {this.Year}\r\n Fuel: {this.FuelQuantity:F2}\r\n";
        }

    }
}
