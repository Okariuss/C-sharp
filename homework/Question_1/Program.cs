using System.Collections;
namespace collections_question_1 {

    class Program {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            for (int i = 0; i < numbers.Length; i++) {
                try {
                    System.Console.Write((i+1) + ". sayiyi giriniz: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] <= 0)
                        throw new Exception("Value must be positive");
                }catch (Exception e) {
                    System.Console.WriteLine(e.Message.ToString());
                    i--;
                    continue;
                }

                if (numbers[i] == 2)
                    asallar.Add(numbers[i]);
                else if (numbers[i] == 1)
                    asalOlmayanlar.Add(numbers[i]);
                else {
                    int counter = 0;
                    for (int j = 2; j <= numbers[i]/2; j++) {
                        if (numbers[i] % j == 0) {
                            counter++;
                            break;
                        }
                    }
                    if (counter > 0)
                        asalOlmayanlar.Add(numbers[i]);
                    else
                        asallar.Add(numbers[i]);
                }
                
            }

            asallar.Sort();
            asallar.Reverse();

            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            System.Console.WriteLine("***** Asallar *****");

            foreach (var i in asallar)
                System.Console.Write(i + ", ");

            System.Console.WriteLine("\n***** Asal Olmayanlar *****");

            foreach (var i in asalOlmayanlar)
                System.Console.Write(i + ", ");


            
            System.Console.WriteLine("\n Asal sayıların eleman sayısı: " + asallar.Count + " ve ortalaması + ");
        }
    }
}