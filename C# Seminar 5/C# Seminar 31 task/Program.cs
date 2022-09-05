// Задайте массив из 10 эл, заполн случайными числами из промежутка[-100, 100]. 
//Найдите cevv отрицательных и положит эл-в

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

int [] PositiveAndNegativeSum(int[] array)
{
    int[] res = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) res [0] += array [i];
        else res[1] += array [i];
    }
    return res;
}

void PositiveSum(int[] array)
{
    int positiveSum = 0;
    foreach (int el in array)
    {
        positiveSum += el >0 ? el : 0; //тернарный оператор
        //if (el>0) positiveSum+=el;
        //else positiveSum+=0;
    }
    Console.WriteLine($"Positive sum = {positiveSum}");
}


int [] myArray = GetArray (10, -100, 100);
int [] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", result));
PositiveSum(myArray);
