//Пользователь вводит 2 числа, необходимо найти максимум

Console.Clear();

Console.Write($"Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (num1>num2) 
{
    Console.WriteLine($"Максимум: {num1}");
}
else if (num1<num2) 
{
    Console.WriteLine($"Максимум: {num2}");
}
else
{
    Console.WriteLine($"Числа равны!");
}