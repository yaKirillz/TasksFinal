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
            Console.WriteLine($"Количество денег,которые принесет ваш вклад за 1 месяц = {X * ((Y / 100) / 12)} ");
        }

        public void FourthTask() 
        {   // Число А
            decimal A = 0;
            Console.Write("Введите число A: ");
            A = Convert.ToDecimal(Console.ReadLine());

            while (A == 0)
            {
                Console.WriteLine("Пожалуйста введите число отличное от нуля " );
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
            Console.WriteLine($"Ваш X линейного уравнения A*X+B = C равняется {(C-B)/A}");


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


    }


}
