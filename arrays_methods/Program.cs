namespace array_methods {
    class Program {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            System.Console.WriteLine("**** Sirasiz Dizi ****");
            foreach (var sayi in sayiDizisi) {
                System.Console.WriteLine(sayi);
            }

            System.Console.WriteLine("**** Sirali Dizi ****");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //Clear
            System.Console.WriteLine("**** Array Clear ****");
            // sayidizisi elemanlarını kullanarak 2.indexden itibaren 2 tane elemanı 0 lar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //Reverse
            System.Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }     

            //Index Of
            System.Console.WriteLine("**** Array Index Of ****");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            System.Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(sayiDizisi);
            }   
        }
    }
}