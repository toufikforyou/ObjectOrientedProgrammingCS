using System;
using System.Data.Common;

namespace MyProgram
{

    class Car // remove Private
    {
        private string model;
        private int year;
        private float price;

        public Car(string modelName, int yearOfProduction, float carPrice) // public hbe;
        {
            model = modelName; // ulta hbe
            year = yearOfProduction; // ulta hbe
            price = carPrice; // ulta hbe
        }

        public string ModelGetSet
        {
            get { return model; } // getter hbe na
            set { model = value; } // setter hbe na and = value hbe
        }

        public int YearGetSet
        {
            get { return year; } // getter hbe na
            set { year = value; } // setter hbe na and = value hbe
        }

        public float PriceGetSet // int hbe  na float hbe
        {
            get { return price; } // getter hbe na
            set { price = value; } // setter hbe na and = value hbe
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Model:" + ModelGetSet); // call get function 
            Console.WriteLine("Year:" + YearGetSet); // call get function 
            Console.WriteLine("Price:" + PriceGetSet); // call get function 
        }

        public static void Main(string[] arg)
        {
            Car car1 = new Car("Toyota", 2018, 25000); // new hbe;
            car1.DisplayDetails();

            car1.price = 200;

            car1.DisplayDetails();
        }
    }

}