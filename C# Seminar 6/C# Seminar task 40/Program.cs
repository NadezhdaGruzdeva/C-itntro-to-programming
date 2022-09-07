//принимаем на вход 3 числа и проверяем, существует ли треугольник с такими сторонами
//каждая сторона треуголуника меньше суммы 2 др сторон

int ConsoleInputNumber(int indexFrom1ConsoleInputNumber)
{
    Console.Write($"Enter {indexFrom1ConsoleInputNumber} number = ");
    int valueConsoleInputNumber = int.Parse(Console.ReadLine());
    return valueConsoleInputNumber;
}

bool TriangleCheck(int numberTriangleCheck1, int numberTriangleCheck2, int numberTriangleCheck3)
{
    return (numberTriangleCheck1 < numberTriangleCheck2 + numberTriangleCheck3 &
        numberTriangleCheck2 < numberTriangleCheck1 + numberTriangleCheck3 &
        numberTriangleCheck3 < numberTriangleCheck1 + numberTriangleCheck2 
        );
}
int num1 = ConsoleInputNumber(1);
int num2 = ConsoleInputNumber(2);
int num3 = ConsoleInputNumber(3);

if (TriangleCheck (num1,num2,num3) == true) Console.WriteLine("It can be triangle");
else Console.WriteLine("It couldn't be triangle");;






