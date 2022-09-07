// Не используя рекурсию, выведите первые N числе Фибиначи
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

Console.WriteLine(String.Join(" ", Fibanachi(10)));