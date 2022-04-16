using System.Collections;

namespace arraylist
{
    class Program
    {
        public static void Main(string[] args)
        {
            // add
            /*ArrayList list = new ArrayList();
            list.Add("Ayse");
            list.Add(1);
            list.Add(true);
            list.Add('a');

            Console.WriteLine(list[1]);

            foreach (var i in list) Console.WriteLine(i);

            string[] colors = { "red", "black" };
            list.AddRange(colors);

            ArrayList list2 = new ArrayList();
            list2.Add(13);
            list2.Add(154);
            list2.Add(1);
            list2.Add(12);

            //Sort
            list2.Sort();
            foreach (var i in list2) Console.WriteLine(i);

            Console.WriteLine(list2.BinarySearch(13));

            list2.Reverse();

            list2.Clear();*/

            int n = Convert.ToInt32(Console.ReadLine());
        
        Dictionary<string,int> dic = new Dictionary<string,int>();
        
        for (int i = 0; i < n; i++) {
            string a = Console.ReadLine();
            string[] b = a.Split(" ");
            dic.Add(b[0],Convert.ToInt32(b[1]));
        }
        
        string[] names = new string[3];
        for (int i = 0; i < n; i++) {
            names[i] = Console.ReadLine();
        }
        
        for (int i = 0; i < n; i++) {
            if (dic.ContainsKey(names[i])) {
                Console.WriteLine(names[i] + "=" + dic[names[i]]);
            }else {
                Console.WriteLine("Not found");
            }
        }

        }
    }
}