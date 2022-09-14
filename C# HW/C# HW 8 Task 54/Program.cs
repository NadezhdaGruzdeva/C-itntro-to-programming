// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

//Сортировка от макс к мин построчно в двумерном массиве
void SortMaxToMinByRows(int[,] array)
{
    int rowsQty = array.GetLength(0);
    int columnsQty = array.GetLength(1);
    for (int i = 0; i < rowsQty; i++)
    {
        for (int j = 0; j < columnsQty; j++)
        {
            for (int k = 0; k < columnsQty-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temporary = array[i, k + 1];
                    array[i,k + 1] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }
}



int[,] MyArray = GetArray(3,4,1,9);
PrintArray(MyArray);
Console.WriteLine();
SortMaxToMinByRows(MyArray);
PrintArray(MyArray);
