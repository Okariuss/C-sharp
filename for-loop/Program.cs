namespace loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int length = int.Parse(Console.ReadLine() + "");
                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 1) Console.WriteLine(i);
                }
                int evenSum = 0;
                int oddSum = 0;
                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 1) oddSum += i;
                    else evenSum += i;

                }
                Console.WriteLine("even sum: " + evenSum);
                Console.WriteLine("odd sum: " + oddSum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }

        }
    }
}