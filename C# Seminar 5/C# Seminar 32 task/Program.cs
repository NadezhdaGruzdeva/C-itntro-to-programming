// Заменине положительные элементы массива на  отрицательные и наоборот

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

int [] NegativeToPositiveAndPositiveToNegative(int[] array)
{
    int [] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = -array[i];
    }
    return newArray;
}

int [] myArray = GetArray (10, -100, 100);
Console.WriteLine(String.Join(" ", myArray));

int [] ChangedArray = NegativeToPositiveAndPositiveToNegative(myArray);
Console.WriteLine(String.Join(" ", ChangedArray));
