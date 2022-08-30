// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int exponentiation (int baseNumber, int powNumber)
{
    int result = 1;
    for (int i=1; i <= powNumber; i++)
    {
        result = result * baseNumber;
    }
    return result;
}

Console.WriteLine ("Enter number A ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter number B ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Number {numberA} to the power of {numberB} is {exponentiation(numberA, numberB)}");

