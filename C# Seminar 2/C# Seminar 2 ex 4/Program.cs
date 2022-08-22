// Принимаем на вход число и провереяем кратно ли оно 7 и 23 одновременно

Console.Write("Enter number = ");
int number = int.Parse(Console.ReadLine());


int ostatok7 = number % 7;
int ostatok23 = number % 23;

if (ostatok7 == 0 && ostatok23 ==0 )
{
    Console.WriteLine (" Число кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine (" Число не кратно 7 и 23 одновременно");
}
