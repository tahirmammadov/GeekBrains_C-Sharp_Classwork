// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.Write($"Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2*num2==num1)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}else
{
     Console.WriteLine($"{num1} НЕ является квадратом {num2}");
}