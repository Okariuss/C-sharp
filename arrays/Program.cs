namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] colors = new string[5];
            string[] animals = { "Kedi", "Köpek", "Kuş", "Maymun"};
            int[] arr;
            arr = new int[5];
            colors[0] = "red";
            arr[3] = 10;
            Console.WriteLine(animals[0]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(colors[0]);

            Console.WriteLine("Please enter the length of the array: ");
            int len = int.Parse(Console.ReadLine() + "");
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Please enter the {0}. item of array: ", i + 1);
                array[i] = int.Parse(Console.ReadLine() + "");
            }
            int total = 0;

            foreach (int item in array)
            {
                total += item;
            }
            Console.WriteLine("Avarage: " + (total / len));


        }
    }
}