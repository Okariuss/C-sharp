using System;

namespace tip_donusumleri {

    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("---- Implict Conversion----");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "okan";
            char f = 'x';
            object g = e + f + d;
            Console.WriteLine(g);

            Console.WriteLine("---- Explicit Conversion----");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine(v);

            int xx = 6;
            string yy = xx.ToString();

            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine(Toplam);
        }
    }
}