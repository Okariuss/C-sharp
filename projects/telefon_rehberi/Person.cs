namespace directory
{
    class Person {
        private string isim;
        private string soyisim;
        private long number;

        public Person(string isim, string soyisim, long number) {
            this.isim = isim;
            this.soyisim = soyisim;
            this.number = number;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public long Number { get => number; set => number = value; }


    }
}