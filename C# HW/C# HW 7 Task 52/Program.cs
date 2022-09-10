// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//Average by columns
void ColumnAVG(int[,] matr)
{
    int qtyValuesInColumn = matr.GetLength(0);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sumValuesInColumn = 0;
        for (int i = 0; i < qtyValuesInColumn; i++)
        {
            sumValuesInColumn += matr[i,j];
        }
        double avgValuesInColumn = Convert.ToDouble(sumValuesInColumn) / Convert.ToDouble(qtyValuesInColumn);
        Console.Write($"{Math.Round(avgValuesInColumn,1)}; ");
    }
}

Console.WriteLine("Enter m (rows qty) ");
int rowQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n (column qty)");
int columnQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min value");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max value");
int max = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(rowQty, columnQty, min, max);
PrintArray(myArray);

ColumnAVG(myArray);
