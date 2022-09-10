Console.Write("Введите число: ");
string? num = Console.ReadLine();

void Number(string num)
{
  if (num[0]==num[4] || num[1]==num[3])
  {
    Console.WriteLine("Ваше число палиндром.");
  }
  else Console.WriteLine("Ваше число не палиндром.");
}

if (num!.Length == 5)
{
  Number(num);
}
else Console.WriteLine("Введи другое число");