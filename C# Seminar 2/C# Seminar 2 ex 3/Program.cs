// Напишите программу, которая будт принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

Console.Write("Enter first number = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number = ");
int number2 = int.Parse(Console.ReadLine());

int ostatok = number1 % number2;

if (ostatok == 0)
{
    Console.WriteLine ("Первое число кратно второму");
}
else
{
    Console.WriteLine ($"Остаток = {ostatok}" );
}

