namespace loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine() + "");
            int counter = 1;
            int total = 0;
            while (num >= counter)
            {
                total += counter++;
            }

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character++);
            }
            Console.WriteLine();
            string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}