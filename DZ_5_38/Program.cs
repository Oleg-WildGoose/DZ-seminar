Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < num.Length; a++)
{
    if (num[a] > max)
        {
        max = num[a];
        }
    if (num[a] < min)
        {
        min = num[a];
        }
}

Console.WriteLine($"итого {num.Length}. Макс. значение - {max}, мин. значение - {min}");
Console.WriteLine($"Разница между макс. и мин. значениями - {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
        num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
        Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}