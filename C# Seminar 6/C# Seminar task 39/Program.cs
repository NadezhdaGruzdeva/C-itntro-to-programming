// Задом наперед

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

//Задом наперед - требует доп опер памяти для нового массива
int[] ReverseArray(int [] array)
{
    int size = array.Length;
    int [] result = new int [size];
    for (int i=0; i < size; i++)
    {
        result [i] = array [size - 1 - i];
    }
    return result;

}

//Задом наперед - не требует доп опер памяти для нового массива
void ReverseArray2(int [] array)
{ 
    int size = array.Length;
    int [] result = new int [size];
    for (int i=0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int [] myArray = GetArray(10,1,9);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine();

Console.WriteLine(String.Join(" ", ReverseArray(myArray)));


ReverseArray2(myArray);
Console.WriteLine(String.Join(" ", myArray));


