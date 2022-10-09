// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите положительные числа: M и N.");
int m = InputInt("Введите M: ");
if (m < 0)
{
    Console.Write("Ошибка M. Давай по новой");
    return;
}
int n = InputInt("Введите N: ");
if (n < 0)
{
    Console.Write("Ошибка N. Давай по новой");
    return;
}
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}