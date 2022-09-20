// Транспонирование
int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                tempArray[j, i] = array[i, j];
            }
        }
        return tempArray;
    }
    else
    {
        Console.WriteLine("Невозможно поменять местами строки и столбцы");
        return array;
    }
}

