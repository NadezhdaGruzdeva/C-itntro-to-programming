// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// генерация массива manual input Values
string[] GetArray (int sizeGetArray)
{
    string [] arrayGetArray = new string [sizeGetArray];
    for (int i = 0; i < sizeGetArray; i++)
    {
        Console.Write($"Enter {i} value : ");
        arrayGetArray[i] = Console.ReadLine();
    }
    return arrayGetArray;
}

//Вывод массива
void ShowArray(string[] arrshowArray)
{
    Console.WriteLine(String.Join(" ", arrshowArray));
}



//Метод для задачи
string [] CutArray(string[] arrCutArray)
{
    int maxValueLength = 3;
    //Defining size for new sorted array
    int sizeSortedArray = 0;
    for (int i = 0; i < arrCutArray.Length; i++)
    {
        if (arrCutArray[i].Length <= maxValueLength)
        {
            sizeSortedArray ++;
        }
    }
    // new sorted array
    string [] sortedArray = new string[sizeSortedArray];
    int j = 0;
    for (int i = 0; i < arrCutArray.Length; i++)
    {
        if (arrCutArray[i].Length <= maxValueLength)
        {
            sortedArray [j] = arrCutArray[i];
            j ++;
        }
    }
    
    return sortedArray;
}

string [] myArr = GetArray(5);
Console.Write("Entered array: ");
ShowArray(myArr);

string [] newArr = CutArray(myArr);
Console.Write("Sorted array: ");
ShowArray(newArr);