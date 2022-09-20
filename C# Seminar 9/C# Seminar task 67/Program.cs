// 63 Напишите программу, кот на вход принимает число а ны выход дает сумму его чисел

int SumFigures (int number)
{
    if (number == 0) return 0;
    return number  % 10 + SumFigures(number/10);
}

Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{SumFigures(n)}");