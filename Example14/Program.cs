// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

// 1st option (separate checking)

Console.Write($"Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num%7 == 0 && num%23 == 0)
{
    Console.WriteLine("да");
}else
{
    Console.WriteLine("нет");
}

//2nd oprion (one general checking)

// Console.Write($"Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());

// if (num%(7*23) == 0)
// {
//     Console.WriteLine("да");
// }else
// {
//     Console.WriteLine("нет");
// }