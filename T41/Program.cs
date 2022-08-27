//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите M случайных чисел равных   ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 15);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
        count++;
}
Console.WriteLine();
Console.WriteLine($" Из {M} введенных чисел {count} из них больше 0 ");
Console.WriteLine();

