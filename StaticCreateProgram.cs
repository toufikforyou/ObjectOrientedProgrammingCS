namespace StaticClassProgram
{
    static class MyClass
    {
        static public int x;
        static public string w;

        static MyClass()
        {
            MyClass.x = x;
            MyClass.w = w;
        }
    }

    // class Program
    // {
    //     static Main()
    //     {
    //         MyClass.x = 10;
    //         MyClass.w = "Hello My Class";

    //         Console.WriteLine(MyClass.x);  // Output: 10
    //         Console.WriteLine(MyClass.w);  // Output: Hello

    //     }
    // }

}