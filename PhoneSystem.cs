using System;

namespace MyProgram
{
    class Phone
    {
        public string Company;
        public string Model;

        private double Price;
        private string ManufacturingDate;

        public Phone(string company, string model, double price, string manufacturingDate)
        {
            Company = company;
            Model = model;
            Price = price;
            ManufacturingDate = manufacturingDate;
        }

        public Phone(string company, string manufacturingDate)
        {
            Company = company;
            ManufacturingDate = manufacturingDate;
            Model = "Unknown";
            Price = 0.0;
        }

        public double PhonePrice
        {
            get { return Price; }
            set { Price = value; }
        }

        public string ManufacturingDateProperty
        {
            get { return ManufacturingDate; }
            set { ManufacturingDate = value; }
        }

        public void DisplayPhoneInfo()
        {
            Console.WriteLine("Phone Information:");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: ৳{Price}");
            Console.WriteLine($"Manufacturing Date: {ManufacturingDate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone samsung = new Phone("Samsung", "Galaxy S23", 100999.99, "2025-01-01");

            samsung.DisplayPhoneInfo();
            Console.WriteLine();

            samsung.PhonePrice = 100899.99;

            Console.WriteLine("Updated Phone Information:");
            samsung.DisplayPhoneInfo();
        }
    }

}