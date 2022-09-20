// Возведите А в степень В  помощью реккурсии

int Pow (int number, int stepen)
{
    if (stepen == 0) return 1;
    return number  * Pow (number, stepen-1);

}

Console.WriteLine("Enter number A");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number B");
int s = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(n,s)}");
