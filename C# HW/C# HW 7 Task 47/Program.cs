// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Fill arrray 2x field by real numbers
double[,] GetArray(int rowQtyGetArray, int columnQtyGetArray, int minValueGetArray, int maxValueGetArray)
{
    double [,] result = new double [rowQtyGetArray, columnQtyGetArray];
    
    for (int i = 0; i < rowQtyGetArray; i++)
    {
        for (int j = 0; j < columnQtyGetArray; j++)
        {
            int intPartGetArray = new Random().Next(minValueGetArray, maxValueGetArray);
            double fractPartGetArray = new Random().NextDouble();
            result[i, j] = intPartGetArray + fractPartGetArray;
        }
    }
    return result;
}

// Print 2x array
void PrintArray(double[,] matr) //Семён, плз подскажите как сделать универсальный метод печати любых массивов, с VAR не выходит что-то
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

Console.WriteLine("Enter m (rows qty) ");
int rowQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n (column qty)");
int columnQty = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min value");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max value");
int max = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(rowQty, columnQty, min, max);
PrintArray(myArray);

