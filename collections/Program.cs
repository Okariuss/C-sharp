namespace collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(34);
            numList.Add(12);
            numList.Add(98);
            numList.Add(32);
            List<string> colorList = new List<string>();
            colorList.Add("red");
            colorList.Add("green");
            colorList.Add("blue");
            colorList.Add("black");

            Console.WriteLine(colorList.Count());

            foreach (var i in numList)
            {
                Console.WriteLine(i);
            }
            foreach (var i in colorList)
            {
                Console.WriteLine(i);
            }

            numList.ForEach(i => Console.WriteLine(i));
            colorList.ForEach(i => Console.WriteLine(i));

            numList.Remove(34);
            colorList.Remove("blue");

            numList.RemoveAt(0);
            colorList.RemoveAt(0);

            if (numList.Contains(98))
            {
                Console.WriteLine("found");
            }
            string[] animals = { "cat", "dog", "bird" };
            List<string> animalList = new List<string>(animals);

            animalList.Clear();

            List<User> users = new List<User>();
            User user1 = new User();
            user1.Name = "Ayse";
            user1.Surname = "Yilmaz";
            user1.Age = 26;
            User user2 = new User();
            user2.Name = "Ozcan";
            user2.Surname = "Caliskan";
            user2.Age = 18;

            users.Add(user1);
            users.Add(user2);

            List<User> userList = new List<User>();
            userList.Add(new User()
            {
                Name = "deniz",
                Surname = "Arda",
                Age = 18
            });
        }

    }
    public class User
    {
        private string name;
        private string surname;

        private int age;

        public string Name { get => name; set => name = value; }

        public string Surname { get => surname; set => surname = value; }

        public int Age { get => age; set => age = value; }

    }
}