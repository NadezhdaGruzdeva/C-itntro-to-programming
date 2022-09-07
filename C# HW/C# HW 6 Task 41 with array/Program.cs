// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//With array

// генерация массива manual
int[] GetArray (int sizeGetArray)
{
    int [] arrayGetArray = new int [sizeGetArray];
    for (int i = 0; i < sizeGetArray; i++)
    {
        Console.Write($"Enter {i+1} number = ");
        arrayGetArray[i] = int.Parse(Console.ReadLine());
    }
    return arrayGetArray;
}

//Вывод массива
void showArray(int[] arrshowArray)
{
    Console.WriteLine(String.Join(" ", arrshowArray));
}

//Count positive values
int CountePositiveValues (int [] arrCountePositiveValues)
{
int counterPositiveValues = 0;
for (int i = 1; i < arrCountePositiveValues.Length; i++)
{
    if (arrCountePositiveValues[i] > 0) counterPositiveValues += 1;
}
return counterPositiveValues;
}

Console.Write("Enter the quantity of numbers ");
int qty = int.Parse(Console.ReadLine());

int [] myArray = GetArray(qty);
showArray(myArray);

Console.Write($"Quantity of values greater than 0 =  {CountePositiveValues(myArray)}");
