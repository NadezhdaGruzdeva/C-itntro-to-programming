
//Заполнение массива рандомными значениями
void FillArray (int [] colletion)
{
    int length = colletion.Length;
    int index = 0;
    while (index < length)
    {
        //присваивание рандомных значений
        colletion[index] = new Random().Next(1, 10);
        index++;
    }
}
//print array
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
     Console.WriteLine(col[position]);
     position ++;   
    }
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

int [] array = new int [10];

FillArray (array);
PrintArray (array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine (pos);
