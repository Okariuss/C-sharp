namespace patika {
    class Program {
        static void Main(string[] args)
        {
            try
            {
                System.Console.Write("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayi " + sayi);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Hata: " + e.Message.ToString());
            }
            //finally {
            //    System.Console.WriteLine("İşlem tamamlandi.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine("Boş değer girdiniz...");
                System.Console.WriteLine(e);
            }
            catch (FormatException e) {
                System.Console.WriteLine("Veri tipi uygun değil...");
                System.Console.WriteLine(e);
            }
            catch (OverflowException e) {
                System.Console.WriteLine("Çok büyük ya da çok küçük değer girdiniz...");
                System.Console.WriteLine(e);
            }
            finally {
                System.Console.WriteLine("İşlem başarıyla tamamlandı...");
            }

        }
    }
}