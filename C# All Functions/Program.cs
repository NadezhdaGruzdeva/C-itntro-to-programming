// генерация массива RandomValues
int[] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

// генерация массива manual input Values
int[] GetArray (int sizeGetArray)
{
    int [] arrayGetArray = new int [sizeGetArray];
    for (int i = 0; i < sizeGetArray; i++)
    {
        arrayGetArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return arrayGetArray;
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

// Первые 2 числа Фибаначи 0 и 1
int[] Fibanachi (int nFibanachi)
{
        int[] arrayFibanachi = new int[nFibanachi];
        arrayFibanachi[0] = 0;
        arrayFibanachi[1] = 1;  
        for (int i = 2; i < nFibanachi; i++)
        {
            arrayFibanachi[i] = arrayFibanachi[i-1] + arrayFibanachi[i-2];  
        }

    return arrayFibanachi;
}

//Ввод чисел с консоли
int ConsoleInputNumber(int indexFrom1ConsoleInputNumber)
{
    Console.Write($"Enter {indexFrom1ConsoleInputNumber} number = ");
    int valueConsoleInputNumber = int.Parse(Console.ReadLine());
    return valueConsoleInputNumber;
}

//Перевод десятичного числа в бинарное
string TransferToBinar(int valueTransferToDvoichnoe)
{
    string BinaryNumTransferToBinar = String.Empty;

    while (valueTransferToDvoichnoe > 0)
    {
        if (valueTransferToDvoichnoe % 2 == 1)
        {
            BinaryNumTransferToBinar += "1";
        }
        else 
        {
            BinaryNumTransferToBinar += "0";
        }
        valueTransferToDvoichnoe = valueTransferToDvoichnoe / 2;
    }
    string ReverseTransferToBinar = String.Empty;
    for (int i = BinaryNumTransferToBinar.Length-1; i >=0 ; i--)
    {
        ReverseTransferToBinar += BinaryNumTransferToBinar[i];
    }
    return ReverseTransferToBinar;
}

//СЧЁТЕСЛИ
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

//Вывод массива
void showArray(int[] arrshowArray)
{
    Console.WriteLine(String.Join(" ", arrshowArray));
}

// Print 2x array
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
    Console.WriteLine();
    }
}

//Fill arrray 2x
int[,] GetArray(int rowQtyGetArray, int columnQtyGetArray, int minValueGetArray, int maxValueGetArray)
{
    int[,] result = new int[rowQtyGetArray, columnQtyGetArray];
    
    for (int i = 0; i < rowQtyGetArray; i++)
    {
        for (int j = 0; j < columnQtyGetArray; j++)
        {
            result[i, j] = new Random().Next(minValueGetArray, maxValueGetArray + 1);
        }
    }

    return result;
}

//Сортировка от макс к мин
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

//Сортировка от мин к макс
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

//Замена символов в тексе
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result =  result + $"{text[i]}";
    }
    return result;
}

//Метод возвращающий первый индекс искомого значения
int IndexOf(int[] colleccion, int find)
{
    int count = colleccion.Length;
    int index = 0;

    int position =-1; //-1-выходит когда элемент не найден


    while (index<count)
    {
        if (colleccion[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

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

