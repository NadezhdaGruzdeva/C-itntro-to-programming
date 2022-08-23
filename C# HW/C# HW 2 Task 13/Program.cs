// Задача 13: Напишите программу, которая выводит третью цифру (слева направо) 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Enter a number ");
int number = int.Parse(Console.ReadLine());

//Check if number has at least 3 figures
if (number < 100 & number > -100)
{
    Console.WriteLine("The entered number doesn't have third figire");
}
else
{
    //for negative numbers - analog of module
    if (number < 0)
    {
        number = - number;
    }

    //Third figure on the right
    int thirdRightFigure = number % 1000 / 100;
    Console.WriteLine($"Third figure on the right is {thirdRightFigure}.");

    //Third figure on the left (Googled)
    char thirdLeftFigure = number.ToString()[2];
    Console.WriteLine($"Third figure on the left is {thirdLeftFigure}.");
}

