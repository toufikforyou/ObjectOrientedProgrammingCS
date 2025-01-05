namespace MyProgram
{
    class MyClass
    {
        public int x;
        public string w;

        public MyClass(int x, string w)
        {
            this.x = x;
            this.w = w;
        }
    }

    class Program
    {
        public static Main()
        {
            MyClass obj = new MyClass(10, "Hello");

            Console.WriteLine(obj.x);  // Output: 10
            Console.WriteLine(obj.w);  // Output: Hello
        }
    }

}