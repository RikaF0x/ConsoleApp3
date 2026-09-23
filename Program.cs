namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        private static void Task1()
        {
            int sz = int.Parse(Console.ReadLine());
            int[] mas = new int[sz];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }
        }
        private static void Task2()
        {
            int sz = int.Parse(Console.ReadLine());
            int[] mas = new int[sz+1];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }
            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }
        }
        static int[] Task3 (int[] mas)
        {
            Array.Sort(mas);
            return mas;
        }
        static void Task4()
        {
            string inp = Console.ReadLine();
            List<int> list = new List<int>();
            int sum = 0;
            while (inp != "exit")
            {
                if (inp != "sum")
                {
                    list.Add(int.Parse(inp));
                }
                else
                {
                    foreach (int i in list)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);
                }
                inp = Console.ReadLine();
            }
        }
        static List<int> Task5 (int[] mas1, int[] mas2)
        {
            List<int> list = new List<int>();
            foreach (int i in mas1)
            {
                list.Add(i);
            }
            foreach (int i in mas1)
            {
                list.Add(i);
            }
            return list;
        }
        static void Task6()
        {
            string[] LibraryB = new string[3] { "библия c#", "библия unity", "книга ни о чём" };
            string book = Console.ReadLine().ToLower();
            bool ex = Array.IndexOf(LibraryB, book) != -1;
            if (ex)
            {
                Console.WriteLine("Да, такая книга есть!");
            }
            else
            {
                Console.WriteLine("Нету такой книги");
            }
        }
    }
}
