// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {num}");

int digit = num%10;
int newNum = num/100*10 + digit;
Console.WriteLine($"Вторая цифра данного числа: {newNum}");