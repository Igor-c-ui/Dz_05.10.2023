using System;

namespace Tumakov_5
{
    internal class Program
    {
        static int Upr5_1(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        static void Upr5_2(ref double par1, ref double par2)
        {
            (par1, par2) = (par2, par1);
        }
        static bool Upr5_3(int n, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        static long Upr5_4(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Upr5_4(n - 1);
            }
        }
        static void Dz5_1(int n, int m, out int nod)
        {
            while (n != 0 && m != 0)
            {
                if (Math.Abs(n) > Math.Abs(m))
                {
                    n %= m;
                }
                else
                {
                    m %= n;
                }
            }
            nod = n + m;
        }
        static void Dz5_1(int first, int second, int third, out int nod)
        {
            int nod1;
            while (first != 0 && second != 0)
            {
                if (Math.Abs(first) > Math.Abs(second))
                {
                    first %= second;
                }
                else
                {
                    second %= first;
                }
            }
            nod1 = first + second;
            while (nod1 != 0 && third != 0)
            {
                if (Math.Abs(nod1) > Math.Abs(third))
                {
                    nod1 %= third;
                }
                else
                {
                    third %= nod1;
                }
            }
            nod = nod1 + third;
        }
        static int Dz5_2(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Dz5_2(n - 1) + Dz5_2(n - 2);
            }
        }



        static void Main(string[] args)
        {
            //Упр.2_1 Написать метод, возвращающий наибольшее из двух чисел
            Console.WriteLine("Упр.2_1 Написать метод, возвращающий наибольшее из двух чисел");
            int n1, n2, result;
            bool flag;
            flag = true;
            do
            {
                Console.Write("Введите первое число: ");
                bool flag1 = int.TryParse(Console.ReadLine(), out n1);
                Console.Write("Введите второе число: ");
                bool flag2 = int.TryParse(Console.ReadLine(), out n2);
                if (flag1 == flag2)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Одно из чисел введено неверно! Попробуйте ещё раз.");
                }
            }
            while (flag);
            result = Upr5_1(n1, n2);
            Console.WriteLine($"Наибольшее из двух чисел - {result}");
            //Упр.2_2 Написать метод, меняющий значения двух передаваемых по ссылке параметров
            Console.WriteLine("Упр.2_2 Написать метод, меняющий значения двух передаваемых по ссылке параметров");
            double firstNumber, secondNumber;
            flag = true;
            do
            {
                Console.Write("Введите первое число: ");
                bool flag1 = double.TryParse(Console.ReadLine(), out firstNumber);
                Console.Write("Введите второе число: ");
                bool flag2 = double.TryParse(Console.ReadLine(), out secondNumber);
                if (flag1 == flag2)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Одно из чисел введено неверно! Попробуйте ещё раз.");
                }
            }
            while (flag);
            Console.WriteLine($"Введённые числа до обмена: 1 число - {firstNumber}; 2 число - {secondNumber}");
            Upr5_2(ref firstNumber, ref secondNumber);
            Console.WriteLine($"Введённые числа после обмена: 1 число - {firstNumber}; 2 число - {secondNumber}");

            //Упр.2_3 Написать метод, вычисляющий факториал и отслеживающий переполнение
            Console.WriteLine("Упр.2_3 Написать метод, вычисляющий факториал и отслеживающий переполнение");
            flag = true;
            do
            {
                Console.Write("Введите число: ");
                bool flag1 = int.TryParse(Console.ReadLine(), out int value);
                if (flag1)
                {
                    if (Upr5_3(value, out long res))
                    {
                        Console.WriteLine($"Факториал введённого числа равен {res}");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Переполнение! Введите число поменьше.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверные данные!");
                }
            }
            while (flag);

            //Упр.2_4 Написать метод, который вычисляет факториал числа с помощью рекурсии
            Console.WriteLine("Упр.2_4 Написать метод, который вычисляет факториал числа с помощью рекурсии");
            Console.Write("Введите число: ");
            flag = true;
            do
            {
                bool flag1 = int.TryParse(Console.ReadLine(), out int n);
                if (flag1 && n != 0)
                {
                    long res = Upr5_4(n);
                    Console.WriteLine($"Факториал введённого числа равен {res}");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверные данные!");
                }
            }
            while (flag);

            //Дз.5_1 Написать метод вычисляющий НОД для двух и трех чисел
            Console.WriteLine("Дз.5_1 Написать метод вычисляющий НОД для двух и трех чисел");
            n1 = 44;
            int m = 24;
            int p = 21;
            Dz5_1(n1, m, out int nod);
            Console.WriteLine($"НОД чисел {n1} и {m} = {nod}");
            Dz5_1(n1, m, p, out int nod1);
            Console.WriteLine($"НОД чисел {n1} и {m} и {p}= {nod1}");

            //Дз.5_2 Написать рекурсивный метод, вычисляющий значение n-го числа последовательности Фибоначчи
            Console.WriteLine("Дз.5_2 Написать рекурсивный метод, вычисляющий значение n-го числа последовательности Фибоначчи");
            n1 = 10;
            Console.WriteLine($"{n1}-ое число ряда Фибоначчи = {Dz5_2(n1)}");
        }
    }
}
