// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите 1-ое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите 2-ое число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if(num2%num1 == 0)
{
    Console.WriteLine($"2-ое число кратно 1-му");
}else
{
    Console.WriteLine($"2-ое число НЕ кратно 1-му, остаток {num2%num1}");
}