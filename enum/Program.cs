namespace _enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Monday);
        }
    }
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday = 24,
        Friday,
        Saturday

    }

    enum WeatherForecast
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        VeryHot = 30

    }
}