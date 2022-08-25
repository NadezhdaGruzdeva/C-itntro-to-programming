//Найти расстояние между точками

Console.WriteLine("Enter X of point 1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y of point 1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X of point 2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y of point 2");
int y2 = int.Parse(Console.ReadLine());

double Rasst = Math.Sqrt((Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)));
Console.WriteLine($"Раастояние между точками = {Rasst:f2}"); //f2 -round to 2 figgires after ","


