namespace static_elements
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Worker.WorkerCount);
            Worker w1 = new Worker("Ayse", "Yilmaz", "Help department");
            Console.WriteLine(Worker.WorkerCount);
            Console.WriteLine(Operations.Sum(2, 1));
            Console.WriteLine(Operations.Extraction(2, 1));
        }
    }
    class Worker
    {
        private static int workerCount;
        private string name;
        private string surname;
        private string department;

        public Worker(string name, string surname, string department)

        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            workerCount++;
        }
        static Worker()
        {
            workerCount = 0;
        }

        public static int WorkerCount { get => workerCount; set => workerCount = value; }

    }

    static class Operations
    {
        public static long Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Extraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}