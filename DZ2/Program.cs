Console.WriteLine("Введи 3 числа ");
            int a, b, c, max;
            Console.WriteLine("Введи свое первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            c = Convert.ToInt32(Console.ReadLine());

            max=a;
if (b>max)max=b;
if (c>max)max=c;
Console.WriteLine("большее число");
Console.WriteLine(max);          