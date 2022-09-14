// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, 
// которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!
int SqrtX (int xforSqrt)
{
    int squareX = 0;
    int result = 0;
    for (int i = 0; i < xforSqrt + 1; i++)
    {
        squareX = i * i;
        if (squareX > xforSqrt)
        {
            break;
        }
        else 
        {
            result = i;
            
        }
    }
    return result;
}

Console.Write("Enter the positive integer number ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"The integer part of the square root of the entered number is {SqrtX(number)}.");
