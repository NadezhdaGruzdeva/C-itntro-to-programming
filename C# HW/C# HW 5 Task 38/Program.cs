// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


//Create array of real numbers (maybe so long but IDK how to make it shoter)
double[] GetArray (int sizeGetArray, int minValueGetArray, int maxValueGetArray)
{
    double [] arrayGetArray = new double [sizeGetArray];
    for (int i = 0; i < sizeGetArray; i++)
    {
        int intPartGetArray = new Random().Next(minValueGetArray, maxValueGetArray);
        double fractPartGetArray = new Random().NextDouble();
        arrayGetArray[i] = intPartGetArray + fractPartGetArray;
    }
    return arrayGetArray;
}

//Find max
double FindMax(double[] arrayFindMax)
{
    double MaxFindMax = arrayFindMax[0];
    for (int i = 1; i < arrayFindMax.Length ; i++)
    {
        if (arrayFindMax[i] > MaxFindMax)
        {
            MaxFindMax = arrayFindMax[i];
        }
    }
    return MaxFindMax;
}

//Find min
double FindMin(double[] arrayFindMin)
{
    double MinFindMin = arrayFindMin[0];
    for (int i = 1; i < arrayFindMin.Length ; i++)
    {
        if (arrayFindMin[i] < MinFindMin)
        {
            MinFindMin = arrayFindMin[i];
        }
    }
    return MinFindMin;
}

//Amplitude
double Amplitude (double[] arrayAmplitude)
{
    double resultAmplitide = FindMax(arrayAmplitude) - FindMin(arrayAmplitude);
    return resultAmplitide;
}

Console.WriteLine(" ");
Console.WriteLine("Array values:");
double [] myArray = GetArray (9, 0, 5);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(" ");

double max = FindMax(myArray);
Console.WriteLine($"Maximum is {max}");

double min = FindMin(myArray);
Console.WriteLine($"Minimum is {min}");

double amplitude = Amplitude(myArray);
Console.WriteLine($"Amplitude is {amplitude}");