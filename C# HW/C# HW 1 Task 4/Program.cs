// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//data unput
Console.Write("Enter the first  number ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third  number ");
int number3 = int.Parse(Console.ReadLine());

Console.Write("Maximum number is ");

//If-Else 
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write(number1);
    }
    else
    {
        Console.Write(number3);
    }
}
else
{
    if (number2 > number3)
    {
        Console.Write(number2);
    }
    else
    {;
        Console.Write(number3);
    }
}