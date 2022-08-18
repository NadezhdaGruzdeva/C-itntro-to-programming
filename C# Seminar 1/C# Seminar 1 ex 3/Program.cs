// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
int negetiveNumber = - number;
//Console.WriteLine(negetiveNumber);
int numberForWhile = negetiveNumber;

while (numberForWhile <= number)
{
    Console.WritLine(numberForWhile);
    numberForWhile = numberForWhile +1;
}
