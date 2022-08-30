// Напишите программу, кот выводит массив из 8 элементо, заполненный 0 и 1 в случаном порядке

int [] massiv8 ()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void showArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"{arr[i]}, ");
    }
    Console.WriteLine();
}

showArray (massiv8());

Console.WriteLine(String.Join(", ", massiv8()));