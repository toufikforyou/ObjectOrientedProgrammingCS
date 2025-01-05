namespace MyProgram
{
    class Example
    {
        public int a;
        private double c;
        private string str;

        class Example
        {
            public int a;
            private double c;
            private string str;
            public Example(int a, double c, string str)
            {
                this.a = a;
                this.c = c;
                this.str = str;
            }
            public Example(int a, double c)
            {
                this.a = a;
                this.c = c;
            }
        }

        public string Str
        {
            get { return str; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double Sum()
        {
            return a + c;
        }
    }

}