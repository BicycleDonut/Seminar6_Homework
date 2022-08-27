﻿//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
Console.Write(first);
Console.Write(second);
for (int i = 1; i < N-1; i++)
{
    int sumfibo = first + second;
    Console.Write(sumfibo);
    first = second;
    second = sumfibo;
}
Console.WriteLine();


