// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//Fill arrray 2x
int[,] GetArray(int rowQtyGetArray, int columnQtyGetArray, int minValueGetArray, int maxValueGetArray)
{
    int[,] result = new int[rowQtyGetArray, columnQtyGetArray];

    for (int i = 0; i < rowQtyGetArray; i++)
    {
        for (int j = 0; j < columnQtyGetArray; j++)
        {
            result[i, j] = new Random().Next(minValueGetArray, maxValueGetArray + 1);
        }
    }

    return result;
}

// Arrays Multiplication
int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    
    int [,] multiplArray = new int [array1.GetLength(0),array2.GetLength(1)];
    // if (array1.GetLength(1) == array2.GetLength(0)) // непонятно как сделать проверку условий в функции, которая возращает згначение
    // { 
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    multiplArray[i,j] += array1[i,k] * array2 [k,j];
                }
            }
        }
    return multiplArray;
    // }

}


int[,] MyArray1 = GetArray(2,3,1,5);
Console.WriteLine("My array1");
PrintArray(MyArray1);

int[,] MyArray2 = GetArray(3,2,1,5);
Console.WriteLine("My array2");
PrintArray(MyArray2);

Console.WriteLine("Multiplied array");
PrintArray(MultiplyArrays(MyArray1,MyArray2));

