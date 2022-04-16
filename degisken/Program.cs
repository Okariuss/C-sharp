using System;

namespace degisken {

    class Program {
        static void Main(string[] args) {
            
            byte b = 5;         // 1 byte
            sbyte c = 5;        // 1 byte

            short s = 5;        // 2 byte
            ushort us = 5;      // 2 byte

            Int16 i16 = 2;      // 2 byte
            int i = 2;          // 4 byte
            Int32 i32 = 2;      // 4 byte
            Int64 i64 = 2;      // 8 byte

            uint ui = 2;        // 4 byte
            long l = 4;         // 8 byte
            ulong ul = 4;       // 8 byte

            //Reel Sayılar
            float f = 5;        // 4 byte
            double d = 5;       // 8 byte
            decimal de = 5;     // 16 byte

            char ch = '2';      // 2 byte
            string str = "Okan"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Okan Orkun";
            string ad = "Okan";
            string soyad = "Orkan";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            // boolean

            bool bool1 = 10>2;

            // degişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            System.Console.WriteLine(yeniDeger); // Çıktısı 2020
        
            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21); // Çıktısı 40
        
            int int22 = int20 + int.Parse(str20); // Çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);
        }
    }


}