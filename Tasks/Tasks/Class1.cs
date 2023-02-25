using System;

namespace Tasks
{
    public class Class1
    {
        public void FirstTask()
        {
            Console.WriteLine("Ведите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите число B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Вычисляю..."); ;
            Console.WriteLine();
            Console.WriteLine($"A/B = {A / B}");
            Console.WriteLine($"Остаток от деления = {A % B}");

        }
        public void SecondTask()
        {
            Console.WriteLine("Введите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Вычисляю...");
            Console.WriteLine();
            Console.WriteLine($"{(5 * A + B * B) / (B - A)}");
        }

        public void ThirdTask()
        {
            Console.Write("Введите сумму вклада Y: ");
            decimal Y = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Под какой процент годовых? X: ");
            decimal X = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Вычисляю...");
            Console.WriteLine();
            Console.WriteLine($"Количество денег,которые принесет ваш вклад за 1 месяц = {X * ((Y / 100m) / 12m)} ");
        }

        public void FourthTask()
        {   // Число А
            decimal A = 0;
            Console.Write("Введите число A: ");
            A = Convert.ToDecimal(Console.ReadLine());

            while (A == 0)
            {
                Console.WriteLine("Пожалуйста введите число отличное от нуля ");
                A = Convert.ToDecimal(Console.ReadLine());
            }

            // Число В
            decimal B = 0;
            Console.Write("Введите число B: ");
            B = Convert.ToDecimal(Console.ReadLine());

            while (B == 0)
            {
                Console.WriteLine("Пожалуйста введите число отличное от нуля ");
                B = Convert.ToDecimal(Console.ReadLine());
            }

            // Число С
            decimal C = 0;
            Console.Write("Введите число C: ");
            C = Convert.ToDecimal(Console.ReadLine());

            while (C == 0)
            {
                Console.WriteLine("Пожалуйста введите число отличное от нуля ");
                C = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Вычисляю...");
            Console.WriteLine();
            Console.WriteLine($"Ваш X линейного уравнения A*X+B = C равняется {(C - B) / A}");


        }
        public void FifthTask()
        {
            Console.WriteLine("Что такое A?");
            string A = Console.ReadLine();

            Console.WriteLine("Что такое B?");
            string B = Console.ReadLine();

            (A, B) = (B, A);

            Console.WriteLine($"неа, А это теперь {A}, а вот В это {B}");
        }

        // Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        public void SixthTask()
        {

            Console.WriteLine("Ведите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите число B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите число C:");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                if (C < B)
                    Console.WriteLine($"{C}, {B}, {A}");
                else
                {
                    if (A > C)
                        Console.WriteLine($"{B}, {C}, {A}");
                    else
                    {
                        if (A > B)
                            Console.WriteLine($"{B}, {A}, {C}");
                    }
                }

            }
            else
            {
                if (C > B)
                {
                    Console.WriteLine($"{A}, {B}, {C}");
                }
                else
                {
                    if (C > A)
                        Console.WriteLine($"{A}, {C}, {B}");
                    else
                        Console.WriteLine($"{C}, {A}, {B}");
                }
            }
        }

        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312
        public void SeventhTask()
        {
            int[] numbers = { 1, 2, 3, 5 };
            foreach (int el1 in numbers)
            {
                Console.Write(el1);
            }
            Console.WriteLine();
            /*numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 1;
            numbers[3] = 2;
            foreach(int el2 in numbers) 
            {
                Console.Write(el2);
            }
            */
            (numbers[0], numbers[2]) = (numbers[2], numbers[0]);
            (numbers[1], numbers[3]) = (numbers[3], numbers[1]);
            foreach (int el2 in numbers)
            {
                Console.Write(el2);
            }
        }
        //Пользователь вводит целые положительные  числа(A, B). Выведите числа в диапазоне от A до B, сумма четных цифр которых больше суммы нечетных.
        public void EighthTask()
        {
            Console.WriteLine("Ведите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите число B:");
            int B = Convert.ToInt32(Console.ReadLine());

            for (int i = A + 1; i < B; i++)
            {
                int temp = i;
                int odd = 0;
                int even = 0;

                while (temp > 0)
                {
                    int num1 = temp % 10;
                    if (num1 % 2 == 0)
                    {
                        even += num1;
                    }
                    else
                    {
                        odd += num1;
                    }
                    temp /= 10;
                }
                if (even > odd)
                {
                    Console.WriteLine($"Суммы четных цифр в это числе, больше чем сумма нечётных: {i}");
                }
            }
        }
        // Отразите массив относительно его главной диагонали (на вход приходит квадрат)
        public void NinthTask()
        {
            int[,] Matrix =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
             };
            for (int y=0; y < Matrix.GetLength(0); y++) 
            
            {
                for (int x = 0; x < Matrix.GetLength(1); x++) 
                {
                    Console.Write(Matrix[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Отразил");
            (Matrix[0, 1], Matrix[1, 0]) = (Matrix[1, 0], Matrix[0, 1]);
            (Matrix[0, 2], Matrix[2, 0]) = (Matrix[2, 0], Matrix[0, 2]);
            (Matrix[1, 2], Matrix[2, 1]) = (Matrix[2, 1], Matrix[1, 2]);
            for (int y = 0; y < Matrix.GetLength(0); y++)

            {
                for (int x = 0; x < Matrix.GetLength(1); x++)
                {
                    Console.Write(Matrix[y, x] + "\t");
                }
                Console.WriteLine();
            }

        }

    }
}
