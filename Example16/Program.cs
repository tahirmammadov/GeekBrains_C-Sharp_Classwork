﻿// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.Write($"Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}