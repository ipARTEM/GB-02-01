using System;

namespace GB_02_01
{
    class Program
    {
        static int num;
        static string q;
        static void PrimeNumber()
        {
            do
            {
           // NewCycle:
                int d = 0;
                int i = 2;

                do
                {
                    Console.WriteLine("Введите число для проверки, простое оно или составное: ");
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        //Console.WriteLine("Введите число!");
                        //goto NewCycle;
                    }
                    if (num <= 0)
                    {
                        Console.WriteLine("Введите положительное целое число!");
                        Console.WriteLine("Нажмите на 'q' и 'enter'для выхода из цикла:");
                    }
                        
                } while (num <= 0);

                while (i < num)
                {
                    if (num % i == 0)
                    {
                        d++;
                    }
                    i++;
                }

                if (d == 0)
                    Console.WriteLine($"{num} -число простое ");
                else
                    Console.WriteLine($"{num} -число составное ");

                Console.WriteLine("Нажмите на 'q' и 'enter'для выхода из цикла:");

                q = Console.ReadLine();
            } while (q != "q");
        }

        static void Main(string[] args)
        {
            PrimeNumber();
        }
        //  Тест
        //  На вход подаем 71, ожидаем простое
        //  На вход подаем 7, ожидаем простое
        //  На вход подаем 19, ожидаем простое
        //  На вход подаем 4, ожидаем составное
        //  На вход подаем 81, ожидаем составное




    }
}
