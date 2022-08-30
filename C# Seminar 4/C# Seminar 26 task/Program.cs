// Напишите программу, кот на входе принимает число (А) и выдает количество цифр в числе.


int figures (int num)
{
    int fig = 0;
    while (num!=0)
    {
        fig ++;
        num = num/10;
    }
    return fig;
}

Console.WriteLine ("Enter number A ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{figures(number)}");