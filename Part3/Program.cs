using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите число для расчёта числа фибоначчи: ");
            string numberStr = Console.ReadLine();

            double numberFibRec = Convert.ToInt32(numberStr);
            double number2 = numberFibRec;
            numberFibRec = GetFibonacciоRec(number2);
            Console.WriteLine($"Число Фибоначчи - расчёт рекурсией  {number2} = {numberFibRec}");

            double numberFibCyc = Convert.ToInt32(numberStr);
            double number3 = GetFibonacciоCyc(numberFibCyc);
            Console.WriteLine($"Число Фибоначчи - расчёт циклом  {numberFibCyc} = {number3}");

        }

        static double GetFibonacciоRec(double number)
        {
            if (number < 1)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            return GetFibonacciоRec(number - 1) + GetFibonacciоRec(number - 2);
        }

        static double GetFibonacciоCyc(double number)
        {
            int p, p1 = 0, p2 = 1;

            if (number <= 1) return p1;

            for (int j = 1; j < number; j++)
            {
                p = p1;
                p1 = p2;
                p2 = p2 + p;

            }
            return p2;
            




        }




    }
}
