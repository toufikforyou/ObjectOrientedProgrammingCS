using System;

namespace MyProgram
{

    public class Car // remove Private
    {
        private string model;
        private int year;
        private int price; // int hbe because input int;

        public Car(string modelName, int yearOfProduction, int carPrice) // public hbe; and carPrice int hbe;
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

        public int PriceGetSet // int hbe  na float hbe and float na hoye int hbe;
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
    }

    public class Program // create a class for main method call automatically;
    {
        public static void Main(string[] arg)
        {
            Car car1 = new Car("Toyota", 2018, 25000); // new hbe;
            car1.DisplayDetails();

            car1.PriceGetSet = 200; // call setter function;

            car1.DisplayDetails();
        }
    }

}