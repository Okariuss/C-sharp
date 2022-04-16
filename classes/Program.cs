namespace classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan w1 = new Calisan();
            w1.name = "ayse";
            w1.surname = "kara";
            w1.no = 551651;
            w1.department = "Purchase department";

            w1.workerInfo();
        }
    }

    class Calisan
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public void workerInfo()
        {
            Console.WriteLine("Worker name: " + name);
            Console.WriteLine("Worker surname: " + surname);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + department);
        }

    }
}