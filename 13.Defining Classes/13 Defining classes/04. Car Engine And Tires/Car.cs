using System;

namespace CarManufacturer
{
    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
           
           
        } 
        
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            this.FuelQuantity= fuelQuantity;
            this.fuelConsumption= fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            :this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires;

        }

        public Tire[] Tiers
        {
            get { return tires; }
            set { tires = value; }
        }


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Make 
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model 
        {
            get { return this.model; } 
            set { this.model= value; } 
        }
        public int Year 
        {
            get { return this.year;}
            set { this.year = value; }
        }

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
