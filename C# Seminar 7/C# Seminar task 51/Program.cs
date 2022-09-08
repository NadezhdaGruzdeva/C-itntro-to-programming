// Задайте двумерный массив.
//Найдите сумму элементов, находящихся на главной диагонали
//с индексами (0,0), (1,1) и т д

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
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void diagonalArrayElementsSumm (int[,] collection2)
{
    int Summ = 0; 
    for (int diagonalPosition = 0; diagonalPosition < collection2.GetLength(0); diagonalPosition++)
    {
        {
           Summ = Summ + collection2[diagonalPosition, diagonalPosition];
        }   
    }
    Console.WriteLine ($"Сумма диагональных элементов массива равна {Summ}");
}

Console.WriteLine("Enter m (rows qty) ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n (column qty)");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);
diagonalArrayElementsSumm(myArray);