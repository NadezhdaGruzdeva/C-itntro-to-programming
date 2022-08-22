// Напишите программу, ко принимимает на вход 2 числа и проверяет 
//явл ли одно число квадратом другогл
Console.Write("Enter first number = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number = ");
int number2 = int.Parse(Console.ReadLine());

int kvadratNumber1 = number1 * number1;
int kvadratNumber2 = number2 * number2;

if (kvadratNumber1 == number2 || kvadratNumber2 == number1)
{
    Console.WriteLine ("Квадрат одного числа равен другому");
}
else
{
    Console.WriteLine ("Квадрат одного числа не равен другому");
}
