﻿Console.WriteLine("Введите размер спирального массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];
int num = 1;
int i = 0;
int j = 0;
while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
PrintArray(nums);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}
// Надеюсь с таким больше не буду пересекаться, это писец :(