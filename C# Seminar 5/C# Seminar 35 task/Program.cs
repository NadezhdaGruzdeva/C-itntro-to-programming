// Задайте одномерный массив со 123 случайных чиселю
//Найдите кол-во элементгов массива значения кот лежат в диапозоне [10, 99]

// Определить присутствует ли заданное значение в массиве

// генерация массива
int[] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int LookingForValue(int[] arrayLook, int minSearchingValue, int maxSearchingValue)
{
    int qtySearchValues = 0;
    for (int i = 0; i < arrayLook.Length; i++)
    {
        if (arrayLook[i] >= minSearchingValue & arrayLook[i] <= maxSearchingValue)
         qtySearchValues ++;
    }
    return qtySearchValues;
}

int [] myArray = GetArray (123, 0, 2000);
Console.WriteLine(String.Join(" ", myArray));

int result = LookingForValue(myArray, 10, 99);
Console.WriteLine(result);

