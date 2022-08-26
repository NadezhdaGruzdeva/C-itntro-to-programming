// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Distance = $\sqrt{(x2-x1)^{2} + (y2-y1)^{2} + (z2-z1)^{2}}$ 

Console.WriteLine("Enter X of point 1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y of point 1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z of point 1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X of point 2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y of point 2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z of point 2");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)));
Console.WriteLine($"The distance = {distance:f2}"); //f2 -round to 2 figures after ","
