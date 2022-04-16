using System.Collections;
namespace collections_question_3 {
    class Program {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Bir cümle giriniz: ");

            
            string sentence = Console.ReadLine();
            
            



            char[] vovels = {'a','e','ı','i','o','ö','u','ü'};

            char[] charSentence = sentence.ToCharArray();

            ArrayList chars = new ArrayList();
            foreach (var i in charSentence) {
                if (vovels.Contains(i))
                    chars.Add(i);
            }

            foreach (var i in chars)
            {
                System.Console.WriteLine(i + " ");
            }
        }
    }
}