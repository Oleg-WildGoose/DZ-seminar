Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());
    int SumNumber(int N)
    {
    int cn = Convert.ToString(N).Length;
    int prog = 0;
    int result = 0;
        for (int i = 0; i < cn; i++)
        {
        prog = N - N % 10;
        result = result + (N - prog);
        N = N / 10;
        }
    return result;
    }
int sumN = SumNumber(N);
Console.WriteLine("Сумма цифр в числе - " + sumN);