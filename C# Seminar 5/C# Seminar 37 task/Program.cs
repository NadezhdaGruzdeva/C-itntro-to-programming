// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и тд


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

int [] PairMultipl(int[] arrayPairMultipl)
{
    int sizepMultArray =  (arrayPairMultipl.Length + 1)/2;
    int [] pMultArray = new int [sizepMultArray];
    for (int i = 0; i < sizepMultArray; i++)
    {
        if (i == arrayPairMultipl.Length - 1 - i)
        {
            pMultArray [i] = arrayPairMultipl[i];
        }  
        else
        {
            pMultArray [i] = arrayPairMultipl[i] * arrayPairMultipl[arrayPairMultipl.Length - 1 - i];
        }
    }
    return pMultArray;
}

int [] myArray = GetArray (6, 0, 6);
Console.WriteLine(String.Join(" ", myArray));

int [] result = PairMultipl(myArray);
Console.WriteLine(String.Join(" ", result));
