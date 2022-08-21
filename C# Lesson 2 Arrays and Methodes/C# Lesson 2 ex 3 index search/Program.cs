// поиск индекса с нужным значением
int [] array ={4,4,3,4,5,6,7,81,9};
//количество эл массива
int n = array.Length;

//искомое значение
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        //прекратить работу программы
        break;
    }
    //index = index +1;
    index++;
}

