// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Input number N
Console.WriteLine("Enter number");
int inputNumber = int.Parse(Console.ReadLine());

int outputNumber = 2;

if (outputNumber > inputNumber)
{
    Console.WriteLine("It's nothing to declare. The entered number is too small");
}
else
{
    while (outputNumber <= inputNumber)
    {
        Console.Write(outputNumber);
        Console.Write(" ");
        outputNumber = outputNumber +2;
    }
}