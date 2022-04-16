namespace method_overloading_out_par
{
    class Program
    {
        public static void Main(string[] args)
        {
            string num = "999";
            bool res = int.TryParse(num, out int outNum);
            if (res) Console.WriteLine("Basarili: " + outNum);
            else Console.WriteLine("Basarisiz");

            Methods m = new Methods();
            m.Sum(1, 2, out int sum);
            Console.WriteLine(sum);
            m.Write(1);
            m.Write("asd");
            m.Write(1, "asd");
        }
    }
    class Methods
    {
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        public void Write(int num)
        {
            Console.WriteLine(num);
        }
        public void Write(int num, string str)
        {
            Console.WriteLine(num + str);
        }
    }
}