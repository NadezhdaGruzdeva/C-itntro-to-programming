// Напишите программу, кот на входе принимает число (А) и выдает произведение чисел от 1 до N.

int multip (int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine ("Enter number A ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{multip(number)}");