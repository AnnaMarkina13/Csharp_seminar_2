// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (number > 99 && number < 1000)
    {
        break;
    }
    System.Console.Write("Ошибка! Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine($"Вторая цифра числа - {number / 10 % 10}.");
