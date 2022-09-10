Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
void Cube(int[] a){
  int b = 0;
  int length = a.Length;
  while (b <  length){
    a[b] = Convert.ToInt32(Math.Pow(b, 3));
    b++;
  }
}
void PrintArry(int[] coll){
  int b = coll.Length;
  int i = 0;
  while(i < b){
    Console.Write(coll[i]+ " ");
    i++;
  }
} 

int[] kvd = new int[a+1];
Cube(kvd);
PrintArry(kvd);