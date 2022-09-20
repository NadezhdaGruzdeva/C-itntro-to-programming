// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((n == 0) && (m != 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Enter number A ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter number B ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"The value of the Ackermann function of the numbers A and B is {Akkerman(a,b)}");

