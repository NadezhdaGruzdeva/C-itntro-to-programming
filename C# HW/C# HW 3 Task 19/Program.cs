// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a number ");
int number = int.Parse(Console.ReadLine());

//Check if number has 5 figures
if (number < -99999 || number > 99999 || number < 10000 & number > -10000)
{
    Console.WriteLine("The entered number has more or less then 5 figires");
}
else
{
    //First figure on the right
    int firstRightFigure = number % 10;
    //Console.WriteLine($"First figure on the right is {firstRightFigure}.");

    //Second figure on the right
    int secondRightFigure = number % 100 / 10;
    //Console.WriteLine($"Second figure on the right is {secondRightFigure}.");

    //Third figure on the left 
    int thirdRightFigure = number % 1000 / 100;
    //Console.WriteLine($"Third figure on the right is {thirdRightFigure}.");

    //Fourth figure on the left 
    int fourthRightFigure = number % 10000 / 1000;
    //Console.WriteLine($"Fourth figure on the right is {fourthRightFigure}.");

    //Fifth figure on the left 
    int fifthRightFigure = number / 10000;
    //Console.WriteLine($"Fifth figure on the left is {fifthRightFigure}.");

    //Find palindrom
    int palindrom = firstRightFigure * 10000 + secondRightFigure * 1000 + thirdRightFigure * 100 + 
    fourthRightFigure * 10 + fifthRightFigure;
    Console.WriteLine($"Palindrom of entered number is {palindrom}.");

    //Comparrison of entered number with palindrom
    if (number == palindrom)
    {
        Console.WriteLine("Palindrom of entered number is equal the number.");
    }
    else
    {
        Console.WriteLine("Palindrom of entered number is unequal the number.");
    }

}