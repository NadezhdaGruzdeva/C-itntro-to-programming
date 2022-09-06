// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

//count even values in array
int QtyEvenValues(int[] arrayQtyEvenValues)
{
    int counterQtyEvenValue = 0;
    for (int i = 0; i < arrayQtyEvenValues.Length ; i++)
    {
        if (arrayQtyEvenValues[i] % 2 == 0)
        {
            counterQtyEvenValue ++;
        }
    }
    return counterQtyEvenValue;
}

int [] myArray = GetArray (10, 100, 999);
Console.WriteLine(String.Join(" ", myArray));

int result = QtyEvenValues(myArray);
Console.WriteLine(String.Join(" ", result));
