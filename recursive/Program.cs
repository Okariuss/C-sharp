namespace recursive_extension_methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Operations o = new Operations();
            Console.WriteLine(o.Expo(3, 4));

            string str = "Hello World";
            Console.WriteLine(str.CheckSpace());
            str = str.RemoveWhiteSpaces();
            int[] arr = { 9, 3, 4, 18, 2 };
            arr.SortArr();
            Console.WriteLine(arr[0]);
            Console.WriteLine(5.isEven());
            Console.WriteLine("Hello".getFirst());
        }
    }
    public class Operations
    {
        public int Expo(int num1, int res)
        {
            if (res < 2)
                return num1;
            return Expo(num1, res - 1) * num1;
        }
    }
    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }
        public static void SortArr(this int[] param)
        {
            Array.Sort(param);
        }
        public static bool isEven(this int num)
        {
            return num % 2 == 0;
        }
        public static string getFirst(this string str)
        {
            return str.Substring(0, 1);
        }
    }

}