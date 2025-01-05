namespace MyProgram
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age must be positive.");
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            person.Name = "Jane";
            person.Age = 30;

            person.DisplayInfo();
        }
    }


}