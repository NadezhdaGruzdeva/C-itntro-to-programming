// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumFigures (int num)
{
    int sumFig = 0;
    int fig = 0;
    while (num!=0)
    {
        fig = num % 10;
        sumFig = sumFig + fig;
        num = num/10;
    }
return sumFig;
}

Console.WriteLine ("Enter number ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"The summ of didgets is {sumFigures(number)}");
