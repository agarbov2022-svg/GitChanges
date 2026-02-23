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
                        Console.WriteLine("Невалидна команда!");
                        continue;
                    }

                    int index;
                    bool isValidIndex = int.TryParse(command[1], out index);

                    if (!isValidIndex || index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Невалиден вход!");
                        continue;
                    }

                    array[index] = command[2];
                }
                else
                {
                    Console.WriteLine("Невалидна команда!");
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
