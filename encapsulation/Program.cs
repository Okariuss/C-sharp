namespace encapsulation {
    class Program {
        public static void Main(string[] args) {
            Student s1 = new Student("Ayse", "Yilmaz", 56156, 1);
            s1.StudentInfo();
            s1.IncreaseClassNo();
            s1.StudentInfo();
        }
    }
    class Student {
        private string name;
        private string surname;
        private int studentNo;
        private int classNo;

        public Student() {
        }
        public Student(string name, string surname, int studentNo, int classNo) {
            this.name = name;
            this.surname = surname;
            this.studentNo = studentNo;
            this.classNo = classNo;
        }
        public void StudentInfo() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Student Number: " + studentNo);
            Console.WriteLine("Class number: " + classNo);
        }
        public void IncreaseClassNo() {
            classNo++;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public string Surname {
            get => surname;
            set => surname = value;
        }
        public int StudentNo {
            get => studentNo;
            set => studentNo = value;
        }
        public int ClassNo {
            get => classNo;
            set {
                if (value > 0)
                    classNo = value;


            }
        }
    }
}