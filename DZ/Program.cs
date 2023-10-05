using System;

namespace DZ
{
    internal class Program
    {
        static int Zadanie_2(ref int product, out double average, params int[] array)
        {
            int sum = 0;
            average = 0;
            foreach (int i in array)
            {
                product *= i;
                sum += i;
            }
            average = (double)(sum / array.Length);
            return sum;
        }

        static void Main(string[] args)
        {
            //1 задание. Вывести на экран массив из 20 случайных чисел и поменять местами в нём два числа 
            int[] ints = new int[20];
            Random random = new Random();
            for (int i = 0; i < ints.Length; i++)//Заполнение массива случайными числами
            {
                ints[i] = random.Next(1, 100);
            }
            foreach (int element in ints)//Вывод массива
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nВведите два числа из массива: ");
            if (int.TryParse(Console.ReadLine(), out int n1) && int.TryParse(Console.ReadLine(), out int n2))
            {
                sbyte index_n1 = (sbyte)(Array.IndexOf(ints, n1));
                sbyte index_n2 = (sbyte)(Array.IndexOf(ints, n2));
                if (Array.IndexOf(ints, n1) != -1 && Array.IndexOf(ints, n2) != -1)
                {
                    (ints[index_n1], ints[index_n2]) = (ints[index_n2], ints[index_n1]);
                    foreach (int element in ints)
                    {
                        Console.Write(element + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Эти числа точно есть в массиве?");
                }
            }
            else
            {
                Console.WriteLine("Это числа?");
            }

            //2 задание. Написать метод, который вернет сумму элементов массива, и вывести произведение элементов массива и их среднее арифметическое
            int[] array = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            int product = 1;
            int sum = Zadanie_2(ref product, out double average, array);
            Console.WriteLine($"\nСумма элементов массива = {sum}");
            Console.WriteLine($"Произведение элементов массива = {product}");
            Console.WriteLine($"Среднее арифметическое элементов массива = {average}");
        }
    }
}
