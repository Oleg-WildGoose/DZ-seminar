Console.Write("Введите ряд чисел через запятую без пробелов ");
string? seriesNumbers = Console.ReadLine();

seriesNumbers = seriesNumbers + ",";
string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}
int[] ArrayOfNumbers(string seriesNew)
{ 
  int[] arrayNumbers = new int[1];
  int j =0;
  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      i++;
    }
    arrayNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1){
      arrayNumbers = arrayNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayNumbers;
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
string seriesNew = RemovingSpaces(seriesNumbers);
int[] arrayNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayNumbers);