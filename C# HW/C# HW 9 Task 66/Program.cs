// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummBetween(int startNumber, int endNumber)
{
    if (startNumber == endNumber) return endNumber;
    return endNumber + SummBetween (startNumber, endNumber-1);
}

Console.Write("Enter number A ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter number B ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of elements between A and B is {SummBetween(a,b)}");
