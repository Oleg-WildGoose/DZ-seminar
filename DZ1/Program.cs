Console.WriteLine("Введи 2 числа и там посмотрим");
            Console.Write("Введи   число 1 - ");
            int a = Convert.ToInt32(Console.Read());
            Console.Write("Введи   число 2 - ");
            int b = Convert.ToInt32(Console.Read());
            if ( a > b)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (a < b )
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }
           
