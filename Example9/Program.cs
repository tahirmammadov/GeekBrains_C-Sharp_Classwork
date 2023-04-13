// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

//решение более универсальное: не только для двухзначных чисел
Console.Clear();
int num = new Random().Next(10,100);
Console.WriteLine($"Случайное число: {num}");
int maxDigit = 0;

for (int i = 0; 0 < num; i++)
{
    if (maxDigit <  (num%10)) maxDigit = num%10;
    num /= 10;
}

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");