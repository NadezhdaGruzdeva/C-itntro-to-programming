// 63 Задайте значение N. Напишите программу, кот выдает все натуральные числа от 1 до N

string NumbersRec(int a)
{
    int firstNumber;
    if (a == firstNumber+1) return a.ToString();
    else return NumbersRec(firstNumber+1) + " " ;
}

Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NumbersRec(n));




