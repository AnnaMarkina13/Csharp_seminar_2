// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void findThirdDigit (int number){
    if (number < 100) 
    {
        System.Console.WriteLine("Третьей цифры нет");
        return;
    }
    while (number >= 1000)
    {
        number /= 10;
    }
    System.Console.WriteLine($"Третья цифра числа - {number % 10}.");
}

Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());

findThirdDigit(num);
