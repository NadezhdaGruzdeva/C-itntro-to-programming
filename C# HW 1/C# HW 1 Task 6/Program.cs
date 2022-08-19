// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Enter the number ");
int number = int.Parse(Console.ReadLine());

// My version
if (number-number/2*2 == 0)

//Like in Ivan's example at seminar 1 - checked -it's ok
//if (number % 2 == 0)
{
    Console.Write("Yes. It's an even number");
}
else
{
    Console.Write("No. It's an odd number");
}
