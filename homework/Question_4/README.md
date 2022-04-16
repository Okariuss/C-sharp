# Patika C# Homework 1


1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
   
   ```C#

         public static void printEvens() {

            System.Console.Write("Lütfen bir sayi giriniz: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            if(n <= 0) {
                System.Console.WriteLine("Lütfen pozitif bir sayı girerek tekrar deneyiniz...");
                printEvens();
            }
            else {
                int[] numbers = new int[n];
                for (int i = 0; i < numbers.Length; i++)
                {
                    System.Console.Write("Sayi " + (i+1) + " = ");
                    numbers[i] = Convert.ToInt32(System.Console.ReadLine());
                }

                System.Console.Write("Çift sayılar: ");
                foreach (var i in numbers)
                {
                    if (i % 2 == 0)
                        System.Console.Write(i + ", ");
                }
            }
                
        }

   ```

2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
   
   ```C#
        public static void findDivisible() {
            System.Console.Write("Lütfen bir sayi giriniz: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Lütfen bir sayi giriniz: ");
            int m = Convert.ToInt32(System.Console.ReadLine());

            if(n <= 0) {
                System.Console.WriteLine("Lütfen pozitif bir sayı girerek tekrar deneyiniz...");
                printEvens();
            }else{
                int[] numbers = new int[n];
                for (int i = 0; i < numbers.Length; i++)
                {
                    System.Console.Write("Sayi " + (i+1) + " = ");
                    numbers[i] = Convert.ToInt32(System.Console.ReadLine());
                }

                foreach (var i in numbers)
                {
                    if (i == m || i % m == 0)
                    {
                        System.Console.Write(i + ", ");
                    }
                }
            }

        }
   ```

3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
   
   ```C#
        public static void reverseWords() {
            System.Console.Write("Lütfen bir sayı giriniz: ");
            int n = Convert.ToInt32(System.Console.ReadLine());

            if(n <= 0) {
                System.Console.WriteLine("Lütfen pozitif bir sayı girerek tekrar deneyiniz...");
                reverseWords();
            }else{
                string[] words = new string[n];
                for (int i = 0; i < words.Length; i++)
                {
                    System.Console.Write("Sayi " + (i+1) + " = ");
                    words[i] = System.Console.ReadLine();
                }

                Array.Reverse(words);
                foreach (var item in words)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
    ```

4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

    ```C#
        public static void countWords() {
            System.Console.Write("Lütfen bir cümle giriniz: ");
            string sentence = System.Console.ReadLine();

            string[] words = sentence.Split(" ");

            int totalWord = 0, totalChar = 0;

            foreach (var item in words)
            {
                totalWord++;
                totalChar += item.Length;
            }

            System.Console.WriteLine("Total words " + totalWord + " and total char " + totalChar);
        }
    ```