using System.Collections;
namespace collections_question_2 {

    class Program {
        static void Main(string[] args) {
            ArrayList numbers = new ArrayList();

            ArrayList max_three = new ArrayList();
            ArrayList min_three = new ArrayList();

            for (int i = 0; i < 20; i++) {
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

                numbers.Sort();

                min_three.Add(numbers[0]);
                min_three.Add(numbers[1]);
                min_three.Add(numbers[2]);

                numbers.Reverse();
                max_three.Add(numbers[0]);
                max_three.Add(numbers[1]);
                max_three.Add(numbers[2]);


                double sumMin = 0;
                foreach (var i in min_three) {
                    sumMin = sumMin + i;
                }
                System.Console.WriteLine("The sum of the 3 minimum numbers: " + sumMin + ", and average is " + (sumMin / 3));
                
                
                double sumMax = 0;
                foreach (var i in max_three) {
                    sumMax = sumMax + i;
                }
                System.Console.WriteLine("The sum of the 3 maximum numbers: " + sumMax + ", and average is " + (sumMax / 3));
            }    
        }
    }


}
