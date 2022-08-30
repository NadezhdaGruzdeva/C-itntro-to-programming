// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());

// cycle WHILE
// int count = 1;
// while (count <= N)
// {
//     double cube =  Math.Pow((count),3);
//     Console.Write($"{cube} ");
//     count++;
// }

// cycle FOR
for (int i = 1; i < N; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}
