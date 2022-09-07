// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Without array

//Input values
int ConsoleInputNumber(int indexFrom1ConsoleInputNumber)
{
    Console.Write($"Enter {indexFrom1ConsoleInputNumber} number = ");
    int valueConsoleInputNumber = int.Parse(Console.ReadLine());
    return valueConsoleInputNumber;
}

//Check if positive
bool CheckIfPositive(int valueCheckIfPositive)
{
        if (valueCheckIfPositive > 0) return true;
        else return false;
}

Console.Write("Enter the quantity of numbers ");
int qty = int.Parse(Console.ReadLine());

int counterPositiveValues = 0;
for (int i = 1; i < qty+1; i++)
{
    if (CheckIfPositive(ConsoleInputNumber(i))) counterPositiveValues += 1;
}

Console.Write($"Number of values greater than 0 =  {counterPositiveValues}");
