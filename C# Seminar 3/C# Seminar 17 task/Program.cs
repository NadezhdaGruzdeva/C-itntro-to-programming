//Определите номер четверти точки в декаровой сисеие координат
//Определите номер четверти точки в декаровой сисеие координат
Console.WriteLine("Enter X of point");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0 )
{
    Console.WriteLine("1");
}
else
if (x>0 && y<0 )
{
    Console.WriteLine("4");
}
else
if (x<0 && y>0 )
{
    Console.WriteLine("2");
}
else
if (x<0 && y<0 )
{
    Console.WriteLine("3");
}