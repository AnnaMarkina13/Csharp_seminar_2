// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message) 
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void IsWeekend (int number) 
{
    if (number == 6 || number == 7) 
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}

bool IsDayOfWeek (int number) 
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Это не день недели!");
        return false;
    }
    return true;
}

int num = Prompt("Введите цифру, обозначающую день недели: ");
if (IsDayOfWeek(num)) 
{
    IsWeekend(num);
}
