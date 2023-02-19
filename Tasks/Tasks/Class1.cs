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
    }


}
