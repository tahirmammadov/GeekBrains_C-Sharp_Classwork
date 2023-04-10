//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Clear();

Console.Write($"Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int Square (int number)
{
    return num*num;
}

Console.WriteLine($"Квадрат числа: {Square(num)}");