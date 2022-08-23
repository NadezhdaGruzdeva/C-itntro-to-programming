// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter the number of weekday (1-st day is Monday).");
int number = int.Parse(Console.ReadLine());

//Check if number in intrval [1:7]
if (number < 1 || number > 7)
{
    Console.WriteLine("The entered number is incorrect. The number should be in interval from 1 to 7");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("It's a day off");
    }
    else
    {
        Console.WriteLine("It's a workday");
    }
}

