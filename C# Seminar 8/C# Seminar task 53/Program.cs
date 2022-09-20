// Задайте двумерный массив
// напишите прогр кот меняет местами пер и посл строку массива
// Print 2x array

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

//Chang 1 an last row
int[,] SwapFirstAndLastRow(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temporary = array[0, i];
        array[0, i] = array[lastRowIndex, i];
        array[lastRowIndex, i] = temporary;
    }
    return array;
}

int[,] MyArray = GetArray(5,6,1,9);
PrintArray(MyArray);
Console.WriteLine();
SwapFirstAndLastRow(MyArray);
PrintArray(MyArray);
