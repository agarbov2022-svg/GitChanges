namespace vvv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    if (command.Length != 3)
                    {
                        Console.WriteLine("Invalid command!");
                        continue;
                    }

                    int index;
                    bool isNumber = int.TryParse(command[1], out index);

                    if (!isNumber || index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    array[index] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
