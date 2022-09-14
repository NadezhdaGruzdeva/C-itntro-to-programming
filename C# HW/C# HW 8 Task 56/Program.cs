// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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



//Сумма построчно
int[,] FindSumByRows(int[,] array) //на выход двумерный, чтобы не переделывать метод печати
{
    int rowsQty = array.GetLength(0);
    int columnsQty = array.GetLength(1);
    int[,] result = new int[rowsQty,1];

    for (int i = 0; i < rowsQty; i++)
    {
        // result [i,0] = 0; //хотя он вроде итак с 0 значением изначально
        for (int j = 0; j < columnsQty; j++)
        {
            result[i,0] += array[i,j];
        }

    }
    return result;
}

//Поиск макимума в 2х массиве
int MinValueSearch(int[,] array)
{
    int rowsQty = array.GetLength(0);
    int columnsQty = array.GetLength(1);
    int minValue = array[0,0];

    for (int i = 0; i < rowsQty; i++)
    {
        for (int j = 0; j < columnsQty; j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
            }
        }
    }
return minValue;
}

//Метод возвращающий первый индекс искомого значения
int IndexOf(int[,] colleccion, int find)
{
    int count = colleccion.Length;
    int index = 0;
    int position =-1; //-1-выходит когда элемент не найден
    while (index<count)
    {
        if (colleccion[index,0]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[,] MyArray = GetArray(4,3,1,9);
Console.WriteLine("My array");
PrintArray(MyArray);
Console.WriteLine("Sums of values by rows");
int[,] sumArray = FindSumByRows(MyArray);
PrintArray(sumArray);

Console.WriteLine($"The row with the smallest sum ({MinValueSearch(sumArray)}) of elements is {IndexOf(sumArray,MinValueSearch(sumArray))+1} row (starting from 1).");