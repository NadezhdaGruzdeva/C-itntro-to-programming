// Задайте двумерный массив разм m n каждый эл массива наход по форм n+m,
//вывед мас на экран

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+ j;
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter m (rows qty) ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n (column qty)");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);


