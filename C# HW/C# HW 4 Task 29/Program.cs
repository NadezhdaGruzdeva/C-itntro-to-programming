// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int [] array (int lengthArray, int startDiapasonInclArray, int endDiaposonExclArray)
{
    int[] arr = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        arr[i] = new Random().Next(startDiapasonInclArray,endDiaposonExclArray);
    }
    return arr;
}

Console.WriteLine ("Enter length of array ");
int length = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter start of array values diaposon ");
int startArray = int.Parse(Console.ReadLine());

Console.WriteLine ("Enter end of array values diaposon ");
int endArray = int.Parse(Console.ReadLine());

Console.WriteLine($"Array: {String.Join(" ,", array(length, startArray, endArray))}");
