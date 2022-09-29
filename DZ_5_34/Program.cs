Console.WriteLine("какой размер массива необходим? Укажите количество данных, нажмите Enter");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int e = 0; e < numbers.Length; e++)
    {
        numbers[e] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int e = 0; e < numbers.Length; e++)
    {
        Console.Write(numbers[e] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}