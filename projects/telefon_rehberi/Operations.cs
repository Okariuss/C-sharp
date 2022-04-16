namespace directory
{
    class Operations {

        private List<Person> directory;

        public Operations(List<Person> directory) {
            this.directory = directory;
        }

        public void addNumber() {
            System.Console.Write("İsim: ");
            string isim = Console.ReadLine();
            System.Console.Write("Soyisim: ");
            string soyisim = Console.ReadLine();
            System.Console.Write("Numara: ");
            bool isNumeric = long.TryParse(Console.ReadLine(), out long number);

            if(!isNumeric) {
                System.Console.WriteLine("Geçerli bir numara giriniz...");
                addNumber();
                return;
            }
            
            directory.Add(new Person(isim,soyisim,number));
            System.Console.WriteLine(isim + " " + soyisim + " kişisi rehbere eklendi...");
            directory = directory.OrderBy(o => o.Isim).ToList();
        }

        public void deleteNumber() {
            System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            bool find = false;
            foreach (Person item in directory.ToList())
            {
                if (item.Isim.Equals(name) || item.Soyisim.Equals(name)) {
                    System.Console.WriteLine(item.Isim + " " + item.Soyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string check = Console.ReadLine();

                    if (check.ToLower() == "y" || check.ToLower() == "n") {
                        if (check.ToLower() == "y") {
                            directory.Remove(item);
                            find = true;
                        }else {
                            System.Console.WriteLine("İşlem iptal edildi...");
                            return;
                        }
                    }
                }
            }
            if(find == false) {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                    System.Console.WriteLine(" * Yeniden denemek için      : (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim) {
                        case 1:
                            System.Console.WriteLine("Silme sonlandırıldı.");
                            break;
                        case 2:
                            deleteNumber();
                            break;
                        default:
                            System.Console.WriteLine("Geçerli bir değer girmediniz. Çıkış yapılıyor...");
                            break;
                    }
            }
        }

        public void updateNumber() {
            System.Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            bool find = false;
            foreach (var item in directory.ToList())
            {
                if (item.Isim.Equals(name)  || item.Soyisim.Equals(name)) {
                    System.Console.WriteLine(item.Isim + " " + item.Soyisim + " isimli kişinin bilgilerini güncellemek istiyor musunuz ?(y/n)");
                    string check = Console.ReadLine();

                    if (check.ToLower() == "y" || check.ToLower() == "n") {
                        if (check.ToLower() == "y") {
                            System.Console.WriteLine("İsim: " + item.Isim + "\nSoyisim: " + item.Soyisim + "\nNumara: " + item.Number);
                            System.Console.WriteLine("Hangi bilgiyi güncellemek istiyorsunuz?");
                            System.Console.WriteLine(" * İsim       : (1)");
                            System.Console.WriteLine(" * Soyisim    : (2)");
                            System.Console.WriteLine(" * Numara     : (3)");

                            int secim = Convert.ToInt32(Console.ReadLine());
                            switch (secim) {
                                case 1:
                                    System.Console.WriteLine(item.Isim + " isimli kişinin yeni adını giriniz: ");
                                    string newName = Console.ReadLine();
                                    item.Isim = newName;
                                    System.Console.WriteLine("isim " + item.Isim + " olarak değiştirildi");
                                    break;
                                case 2:
                                    System.Console.WriteLine(item.Soyisim + " isimli kişinin yeni soyadını giriniz: ");
                                    string newSurname = Console.ReadLine();
                                    item.Soyisim = newSurname;
                                    System.Console.WriteLine("Soyisim " + item.Soyisim + " olarak değiştirildi");

                                    break;
                                case 3:
                                    System.Console.WriteLine(item.Number + " numaralı kişinin yeni numarasını giriniz: ");
                                    long newNumber = Convert.ToInt32(Console.ReadLine());
                                    item.Number = newNumber;
                                    System.Console.WriteLine("Numara " + item.Number + " olarak değiştirildi");

                                    break;
                                default:
                                    System.Console.WriteLine("Geçersiz bir değer girdiniz. Çıkış yapılıyor...");
                                    break;
                            }
                            find = true;
                        }else {
                            System.Console.WriteLine("İşlem iptal edildi...");
                            return;
                        }
                    }
                }
                if(find == false) {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine(" * Güncellemeyi sonlandırmak için : (1)");
                    System.Console.WriteLine(" * Yeniden denemek için           : (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim) {
                        case 1:
                            System.Console.WriteLine("Güncelleme sonlandırıldı.");
                            return;
                        case 2:
                            updateNumber();
                            break;
                        default:
                            System.Console.WriteLine("Geçerli bir değer girmediniz. Çıkış yapılıyor...");
                            return;
                    }
                }
            }
        }

        public void listDirectory() {
            System.Console.WriteLine("Hangi sırada sıralamak istiyorsunuz? ");
            System.Console.WriteLine(" * A-Z    : (1)");
            System.Console.WriteLine(" * Z-A    : (2)");

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim) {
                case 1:
                    directory = directory.OrderBy(o => o.Isim).ToList();
                    break;
                case 2:
                    directory.Reverse();
                    break;
            }
            System.Console.WriteLine("Telefon Rehberi\n**********************************************");


            foreach (var i in directory) {
                System.Console.WriteLine("İsim: " + i.Isim);
                System.Console.WriteLine("Soyisim: " + i.Soyisim);
                System.Console.WriteLine("Telefon Numarası: " + i.Number);
                System.Console.WriteLine("-");
            }
        }

        public void searchDirectory() {
            System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************\n");

            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim) {
                case 1:
                    System.Console.WriteLine("İsim veya soyisim giriniz: ");
                    string name = Console.ReadLine();
                    System.Console.WriteLine("Arama Sonuçlarınız:\n**********************************************\n");
                    foreach (var i in directory) {
                        if (name == i.Isim || name == i.Soyisim) {
                            System.Console.WriteLine("İsim: " + i.Isim);
                            System.Console.WriteLine("Soyisim: " + i.Soyisim);
                            System.Console.WriteLine("Telefon Numara: " + i.Number);
                            System.Console.WriteLine("-");
                        }
                    }
                    break;
                case 2:
                    System.Console.WriteLine("Telefon Numarası giriniz: ");
                    long number = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Arama Sonuçlarınız:\n**********************************************\n");
                    foreach (var i in directory) {
                        if (number == i.Number) {
                            System.Console.WriteLine("İsim: " + i.Isim);
                            System.Console.WriteLine("Soyisim: " + i.Soyisim);
                            System.Console.WriteLine("Telefon Numara: " + i.Number);
                            System.Console.WriteLine("-");
                        }
                    }
                    break;
                default:
                    System.Console.WriteLine("Geçersiz bir sayı girdiniz. Çıkış yapılıyor...");
                    break;
            }
        }
    }
}