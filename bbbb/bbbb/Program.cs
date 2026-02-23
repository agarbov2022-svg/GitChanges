namespace bbbb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                if(command == "Reverse")
                {
                    Array.Reverse(a);
                }
                else if(command == "Distinct")
                {
                    string[] unique = a.Distinct();
                    string[] a = unique;
                }
                else if(command == "Replace")
                {
                    int index = int.Parse(Console.ReadLine());
                    string rep = Console.ReadLine();
                    a[index] = $"{rep}";
                }
            }
            Console.WriteLine(a);
        }
    }
}
