// Напишите программу, кот на входе принимает число (А) и выдает на выходе суииу чисел от 1 до А.
Console.WriteLine ("Enter number A ");
int num = int.Parse(Console.ReadLine());


int getNums (int number)
{
    int sum = 0;
    for (int i=1; i <= number; i++)
    {
        sum +=i;
    }
    return sum;
}

Console.WriteLine($"{getNums(num)}");