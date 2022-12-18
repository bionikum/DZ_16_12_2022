// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.Write("Введите числа(через пробел): ");
int[] N = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).ToArray();
int count = 0;
 
for (int i = 0; i < N.Length; i++)
{
    if (N[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во положительных чисел: {count}");
