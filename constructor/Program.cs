namespace constructor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan w1 = new Calisan("Ayse", "Yilmaz", 51515, "Help department");
            Calisan w2 = new Calisan("Okan", "Yilmaz");
            Calisan w3 = new Calisan();
            w1.workerInfo();
            w2.workerInfo();
            w3.workerInfo();
        }
    }
    class Calisan
    {
        public string name;
        public string surname;
        public int no;

        public string department;

        public Calisan(string name, string surname, int no, string department)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.department = department;
        }
        public Calisan(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }
        public Calisan()
        {

        }

        public void workerInfo()
        {
            Console.WriteLine("Worker name: " + name);
            Console.WriteLine("Worker surname: " + surname);
            Console.WriteLine("Worker no: " + no);
            Console.WriteLine("Worker department: " + department);
        }

    }
}