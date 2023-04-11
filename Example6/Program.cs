// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();

Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while((num<100 || num>999) && (num>-100 || num <-999))
{
    Console.Write($"Не верное значение!\nВведите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Результат: {num%10}");
