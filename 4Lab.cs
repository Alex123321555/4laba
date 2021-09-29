﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Программа, находящая сумму всех элементов строки, максимальный элемент строки и его индекс.
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите кол-во элементов");
            string str = Console.ReadLine();
            int sum = 0;
            int max = 0;
            int num = -1;

            int n = int.Parse(str);
            int[] array = new int[n];

            Console.WriteLine("Введите числа");
            for (int j = 0; j < n; j++)
            {
                string line = Console.ReadLine();
                array[j] = int.Parse(line);

                if (array[j] >= 0)
                {
                    sum = sum + array[j];

                    if (array[j] > max)
                    {
                        max = array[j];
                        num = j;
                    }
                }


            }
            if (num != -1)
            {
                Console.WriteLine("Сумма =" + sum);
                Console.WriteLine("Максимальный элемент =" + max);
                Console.WriteLine("Индекс максимального элемента =" + num);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Программа не отвечает");
            }
        }
    }
}