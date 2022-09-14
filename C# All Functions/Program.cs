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

//Поиск макимума в 2х массиве
int MinValueSearch(int[,] array)
{
    int rowsQty = array.GetLength(0);
    int columnsQty = array.GetLength(1);
    int minValue = array[0,0];

    for (int i = 0; i < rowsQty; i++)
    {
        for (int j = 0; j < columnsQty; j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
            }
        }
    }
return
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

//Сортировка от макс к мин построчно в двумерном массиве
void SortMaxToMinByRows(int[,] array)
{
    int rowsQty = array.GetLength(0);
    int columnsQty = array.GetLength(1);
    for (int i = 0; i < rowsQty; i++)
    {
        for (int j = 0; j < columnsQty; j++)
        {
            for (int k = 0; k < columnsQty-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temporary = array[i, k + 1];
                    array[i,k + 1] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }
}

//Fill arrray with unique values
int[] GetArrayWithUniqueValues(int rowQtyGetArray, int columnQtyGetArray, int deepQtyGetArray, int minValueGetArray, int maxValueGetArray)
{
    //int[,,] result = new int[rowQtyGetArray, columnQtyGetArray, deepQtyGetArray];
    
    int sizeFlatArray = rowQtyGetArray * columnQtyGetArray * deepQtyGetArray;
    int[] flatResult = new int[sizeFlatArray]; //для последующего поиска дубликатов
    bool isUnique = true;
    flatResult[0] = new Random().Next(minValueGetArray, maxValueGetArray + 1);

    int indexForFlatArray = 1;
    while (indexForFlatArray < sizeFlatArray)//заполняем массив ранд знач
    {           
        flatResult[indexForFlatArray] = new Random().Next(minValueGetArray, maxValueGetArray + 1);
        
        for (int i = 0; i < indexForFlatArray; i++) //сравниваем с ранее введенными
        {
            if (flatResult[indexForFlatArray] == flatResult[i]) 
            {
                isUnique = false;
                break;
            }
            else
            {
                isUnique = true;
            }
        } 
        if (isUnique == false) continue;   
        else indexForFlatArray++;
    }
return flatResult;
}

void Print3xArrayByRows(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

//Fill arrray 3x with unique values
int[,,] Get3xArrayWithUniqueValues(int rowQtyGetArray, int columnQtyGetArray, int deepQtyGetArray, int minValueGetArray, int maxValueGetArray)
{
    int sizeFlatArray = rowQtyGetArray * columnQtyGetArray * deepQtyGetArray;
    int[] flatResult = new int[sizeFlatArray]; //для последующего поиска дубликатов
    bool isUnique = true;
    flatResult[0] = new Random().Next(minValueGetArray, maxValueGetArray + 1);

    int indexForFlatArray = 1;
    while (indexForFlatArray < sizeFlatArray)//заполняем массив ранд знач
    {           
        flatResult[indexForFlatArray] = new Random().Next(minValueGetArray, maxValueGetArray + 1);
        
        for (int i = 0; i < indexForFlatArray; i++) //сравниваем с ранее введенными
        {
            if (flatResult[indexForFlatArray] == flatResult[i]) 
            {
                isUnique = false;
                break;
            }
            else
            {
                isUnique = true;
            }
        } 
        if (isUnique == false) continue;   
        else indexForFlatArray++;
    }
Console.WriteLine("1x array");
Console.WriteLine(String.Join(" ", flatResult));

int [,,] result = new int[rowQtyGetArray, columnQtyGetArray, deepQtyGetArray];
indexForFlatArray = 0;
for (int i = 0; i < rowQtyGetArray; i++)
    {
    for (int j = 0; j < columnQtyGetArray; j++)
        {
            for (int k = 0; k < deepQtyGetArray; k++)
            {
                result[i, j, k] = flatResult[indexForFlatArray];
                indexForFlatArray++;
            }
        }
    }
return result;

}

//круголя
void RounWalkingThroughArray(int[,] RWTArray)
{
    int qtyRows = RWTArray.GetLength(0);
    int qtyColumns = RWTArray.GetLength(1);

    //оперделяем колво кругов как минимальная сторона массива + 1
    //Эмперич методом выявл зак-ть для мин ст масиива нужны сл кол-во кругов соответственно
    // 1-1, 2-1, 3-2, 4-2, 5-3, 6-3, 7 -4
    int circles =0;
    if (qtyRows < qtyColumns) circles = (qtyRows +1)/2;
    else circles = (qtyColumns +1)/2;


    for (int swit4 = 0; swit4 < circles; swit4++)
    {
        //1 круг = 4 отрезка
        Console.Write($"{swit4 +1} cyrcle ");

        int j =0; //чтобы не было ошибок при повт вызове в др частях

        // 1 отрезок
        int i = qtyRows-1 -swit4;

        for (j = 0 + swit4;j <  qtyColumns - swit4;j++)
        {
            Console.Write($"{RWTArray[i,j]} ");
        }

        // 2 отрезок
        j = qtyColumns-1 - swit4;
        for (i = qtyRows-2 - swit4; i >= 0 + swit4;i--)
        {
            Console.Write($"{RWTArray[i,j]} ");
        }

        // 3 отрезок
        i = 0 + swit4;
        for (j = qtyColumns-2 - swit4; j >= 0 + swit4; j--)
        {
            Console.Write($"{RWTArray[i,j]} ");
        }

        // 4 отрезок 
        j = 0 + swit4;
        for (i = 1 + swit4; i <  qtyRows-1 -swit4; i++)
        {
            Console.Write($"{RWTArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

