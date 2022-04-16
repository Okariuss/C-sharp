namespace directory
{
    class Program{
        static void Main(string[] args)
        {
            List<Person> directory = new List<Person>();
            directory.Add(new Person("okan","orkun",5071893095));
            directory.Add(new Person("kerim","çan",5074555455));
            directory.Add(new Person("süleyman","dadasov",5327896512));
            directory.Add(new Person("göksu","özcan",5451296487));
            directory.Add(new Person("agah","güler",5065461346));
            directory = directory.OrderBy(o => o.Isim).ToList();
            Operations operations = new Operations(directory);

            bool run = true;
            while (run)
            {
                switch (choose())
                {
                    case 1:
                        operations.addNumber();
                        break;
                    case 2:
                        operations.deleteNumber();
                        break;
                    case 3:
                        operations.updateNumber();
                        break;
                    case 4:
                        operations.listDirectory();
                        break;
                    case 5:
                        operations.searchDirectory();
                        break;
                    case 0:
                        System.Console.WriteLine("Çıkış yapılıyor...");
                        run = false;
                        break;
                }
            }
        }

        public static int choose() {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine(" (1) Yeni Numara Kaydetmek");
                System.Console.WriteLine(" (2) Varolan Numarayı Silmek");
                System.Console.WriteLine(" (3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine(" (4) Rehberi Listelemek");
                System.Console.WriteLine(" (5) Rehberde Arama Yapmak");
                System.Console.WriteLine(" (0) Çıkış");
                return Convert.ToInt32(Console.ReadLine());
        }
    }
}