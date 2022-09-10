Console.Write("Введи цифру, обозначающую день недели: ");
int NumberDay = Convert.ToInt32(Console.ReadLine());

{
  if (NumberDay == 6 || NumberDay == 7) 
  {
  Console.WriteLine("выходной");
  }
  else if (NumberDay < 1 || NumberDay > 7) 
  {
    Console.WriteLine("не день недели");
  }
  else Console.WriteLine("не выходной");
}
