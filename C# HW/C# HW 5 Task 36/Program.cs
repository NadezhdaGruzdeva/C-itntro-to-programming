// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// генерация массива c семинара
int[] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

//Sum values with odd indexes
int SumValuesOddIndex(int[] arraySumValuesOddIndex)
{
    int sumSumValuesOddIndex = 0;
    for (int i = 0; i < arraySumValuesOddIndex.Length ; i++)
    {
        if (i % 2 == 1)
        {
            sumSumValuesOddIndex = sumSumValuesOddIndex + arraySumValuesOddIndex[i];
        }
    }
    return sumSumValuesOddIndex;
}

int [] myArray = GetArray (9, -5, 5);
Console.WriteLine(String.Join(" ", myArray));

int result = SumValuesOddIndex(myArray);
Console.WriteLine(result);

