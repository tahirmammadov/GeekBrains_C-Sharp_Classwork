//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();

Console.Write($"Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 0)
{
    Console.Write($"\nНеправильное значение!\nВведите значение больше 0: ");
    n = Convert.ToInt32(Console.ReadLine());
}

//1-st option (loop)
Console.Write("Результат: ");
for (int i = -n; i <= n; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

//2-nd option (recursion)
// void Numbers(int n, int i)
// {
//     if (n >= 0)
//     {
//         Console.Write($"{n} ");
//         i++;
//         Numbers(n - 1, i);
//     }

//     if (n < 0 && i > 1)
//     {
//         Console.Write($"{n} ");
//         i--;
//         Numbers(n - 1, i);
//     }

// }

// Numbers(n, 0);
// Console.WriteLine();