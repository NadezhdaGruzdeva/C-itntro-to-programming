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

string LookingForValue(int[] arrayLook, int searchingValueLook)
{
    string resultLook = "There is no the searching value in array";
    for (int i = 0; i < arrayLook.Length; i++)
    {
        if (arrayLook[i] == searchingValueLook) resultLook = "There is the searching value in array";
    }
    return resultLook;
}

int [] myArray = GetArray (10, 0, 7);
Console.WriteLine(String.Join(" ", myArray));

string result = LookingForValue(myArray, 5);
Console.WriteLine(result);
