// /Напишите программу, которая принимает на вход число и выдете квадраты чисел от 1 до числа

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
    double kvadrat =  Math.Pow((count),2);
    Console.Write($"{kvadrat} ");
    count++;
}



