// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void PrintIntersectionPoint (double b1PrintIntersectionPoin,double k1PrintIntersectionPoin,double b2PrintIntersectionPoin,double k2PrintIntersectionPoin)
{
    if (k1PrintIntersectionPoin == k2PrintIntersectionPoin) //если угл коэф-ы равны, то прямые паралельны
    {
        Console.Write("Lines are parallel. They do not intersect.");
    }
    else
    {
    double xPrintIntersectionPoin = (b2PrintIntersectionPoin-b1PrintIntersectionPoin)/(k1PrintIntersectionPoin -k2PrintIntersectionPoin);
    double yPrintIntersectionPoin = k1PrintIntersectionPoin * xPrintIntersectionPoin +b1PrintIntersectionPoin;
    Console.Write($"x = {xPrintIntersectionPoin}, y = {yPrintIntersectionPoin},"); 
    }

}

Console.Write("Enter b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
PrintIntersectionPoint(b1, k1, b2, k2);
