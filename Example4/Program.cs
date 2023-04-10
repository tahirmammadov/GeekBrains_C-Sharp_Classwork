//  Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();

Console.Write($"Введите день недели в виде числа: ");
int num = Convert.ToInt32(Console.ReadLine());

while(num<=0 || num>7)
{
    Console.Write($"Вы ошиблись!\nВведите число от 1 до 7 включительно: ");
    num = Convert.ToInt32(Console.ReadLine());
}

// 1-st option:

switch (num)
{
    case 1:
        Console.WriteLine($"Monday");
        break;
    case 2:
        Console.WriteLine($"Tuesday");
        break;
    case 3:
        Console.WriteLine($"Wednesday");
        break;
    case 4:
        Console.WriteLine($"Thursday");
        break;
    case 5:
        Console.WriteLine($"Friday");
        break;
    case 6:
        Console.WriteLine($"Saturday");
        break;
    default:
        Console.WriteLine($"Sunday");
        break;
}

// 2-nd option:

// if (num==1)
// {
//     Console.WriteLine($"Monday");
// }else if(num==2)
// {
//     Console.WriteLine($"Tuesday");
// }else if(num==3)
// {
//     Console.WriteLine($"Wednesday");
// }else if(num==4)
// {
//     Console.WriteLine($"Thursday");
// }else if(num==5)
// {
//     Console.WriteLine($"Friday");
// }else if(num==6)
// {
//     Console.WriteLine($"Saturday");
// }else
// {
//     Console.WriteLine($"Sunday");
// }