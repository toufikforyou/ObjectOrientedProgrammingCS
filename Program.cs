namespace BillingSystem
{
    class Billing
    {
        private string name;
        private string project;
        private string price;
        private string date;

        public Billing(string name, string project, string price, string date)
        {
            this.name = name;
            this.project = project;
            this.price = price;
            this.date = date;
        }

        public void GenerateInvoice()
        {
            Console.Clear();
            Console.WriteLine("|-------------------------------------------------------|");
            Console.WriteLine("|\t\tPROJECT MANAGMENT INVOICE\t\t\t|");
            Console.WriteLine("|-------------------------------------------------------|");
            Console.WriteLine("| SN\t|DATE\t\t|NAME \t|PROJECT\t|PRICE");
            Console.WriteLine("|-------------------------------------------------------|");

            Console.WriteLine($"| {1}\t|{date}\t|{name}\t|{project}\t|{price}");
            Console.WriteLine("|-------------------------------------------------------|");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Billing billing = new Billing("FAHIM", "Flatter", "$123", "2024-12-05");

            billing.GenerateInvoice();
        }
    }
}