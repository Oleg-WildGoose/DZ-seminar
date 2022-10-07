Console.WriteLine("укажите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
Console.WriteLine("случайным образом задан массив:");
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double rage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
    rage = (rage + numbers[i, j]);
    }
    rage = rage / n;
    Console.Write(rage + "  ");
}
Console.WriteLine();
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}