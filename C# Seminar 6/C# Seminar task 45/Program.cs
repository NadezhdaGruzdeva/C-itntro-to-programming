// Копия заданного массива с помощью поэлементного копирования

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

//Копия заданного массива с помощью поэлементного копирования
int [] CopyByElements(int[] InputArrayCopyByElements)
{
    int sizeCopyByElements = InputArrayCopyByElements.Length;
    int [] CopyArrayCopyByElements = new int [sizeCopyByElements];
    for (int i = 0; i < sizeCopyByElements; i++)
    {
        CopyArrayCopyByElements[i] = InputArrayCopyByElements[i];
    }
    return CopyArrayCopyByElements;
}

//Вывод массива
void showArray(int[] arrshowArray)
{
    Console.WriteLine(String.Join(" ", arrshowArray));
}

int [] InitialArray = GetArray(10,1,9);

showArray(InitialArray);
showArray(CopyByElements(InitialArray));