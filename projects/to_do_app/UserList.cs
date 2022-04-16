namespace todo {
    public class UserList
    {
        public List<User> all;
        public UserList()
        {
            all = new List<User>();
            all.Add(new User(1, "Samet Koyuncu"));
            all.Add(new User(2, "Jane Lorem"));
            all.Add(new User(3, "John Doe"));
            all.Add(new User(4, "Jess Ipsum"));
        }
    }
}