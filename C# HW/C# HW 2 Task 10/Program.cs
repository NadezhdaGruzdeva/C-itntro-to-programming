// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a three-digit number ");
int number = int.Parse(Console.ReadLine());

//Check if number was entered correctly
if ((number < 100 & number > -100)  || number < -999 || number > 999)
{
    Console.WriteLine("You have entered an invalid value. It's not the three-digit number.");
    //break - не работает, т к не в цикле(( придется писать основную часть в Else
}
else
{
    int secondFigure = number / 10 % 10;
    Console.Write($"Second figure is {secondFigure}.");
}

