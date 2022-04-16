namespace methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Methods m = new Methods();
            m.Write(Sum(1, 2) + "");
            m.Write(m.IncreaseSum(2, 3) + "");

        }
        static int Sum(int num1, int num2)
        {

            return num1 + num2;
        }
    }
    class Methods
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        public int IncreaseSum(int num1, int num2)
        {
            return ++num1 + (++num2);
        }
    }
}