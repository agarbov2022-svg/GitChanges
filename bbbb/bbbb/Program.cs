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
                    a = a.Distinct().ToArray();
                }
                else if(command == "Replace")
                {
                    string[] aa = Console.ReadLine().Split();
                    int index = int.Parse(aa[0]);
                    string rep = aa[1];
                    if (index >= 0 && index < a.Length)
                    {
                        a[index] = rep;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
    