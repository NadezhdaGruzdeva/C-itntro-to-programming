// Задача 50. Напишите программу, которая на вход принимает число и 
// генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

//Looking for value index in 2xarray
void SearchValue(int[,] matr,int ValueSearchValue)
{
    int indexIsearchValue = -1;
    int indexJsearchValue = -1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == ValueSearchValue)
            {
                indexIsearchValue = i;
                indexJsearchValue = j;
                break; //Похоже работает только в этом цикле, а как выйти из обоих циклов при выполнении усл-я?
            }   
        }
    }
    if (indexIsearchValue == -1) Console.WriteLine("There is no searching value in the array.");
    else         Console.WriteLine($"Index of searching value in the array is [{indexIsearchValue},{indexJsearchValue}].");
}

Console.WriteLine("Enter m (rows qty) ");
int rowQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n (column qty)");
int columnQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min value");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max value");
int max = int.Parse(Console.ReadLine());

Console.WriteLine("Enter searching value");
int searchingValue = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rowQty, columnQty, min, max);
PrintArray(myArray);

SearchValue(myArray,searchingValue);
