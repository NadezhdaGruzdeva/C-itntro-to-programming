// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
int devidedNumber = number / 10;
int ostatok = number - devidedNumber *10;

Console.WriteLine(ostatok);
