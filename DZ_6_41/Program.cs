internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую, без пробелов - ");
        int[] num = StringToNum(Console.ReadLine());
        PrintArray(num);
        int n = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0)
            {
                n++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Значений больше нуля - {n}");
        int[] StringToNum(string input)
        {
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    count++;
                }
            }

            int[] num = new int[count];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";

                while (input[i] != ',')
                {
                    if (i != input.Length - 1)
                    {
                        temp += input[i].ToString();
                        i++;
                    }
                    else
                    {
                        temp += input[i].ToString();
                        break;
                    }
                }
                num[index] = Convert.ToInt32(temp);
                index++;
            }
            return num;
        }
        void PrintArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
        }
    }
}