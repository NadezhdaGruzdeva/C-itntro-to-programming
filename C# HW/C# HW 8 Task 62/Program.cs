// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Заполнение двуменрного массива по спирали с верхнего левого угла по часовой стрелке
void FillArrayByRounWalking(int[,] RWTArray)
{
    int qtyRows = RWTArray.GetLength(0);
    int qtyColumns = RWTArray.GetLength(1);

    //оперделяем колво кругов как минимальная сторона массива + 1
    //Эмперич методом выявл зак-ть для мин ст масиива нужны сл кол-во кругов соответственно
    // 1-1, 2-1, 3-2, 4-2, 5-3, 6-3, 7 -4
    int circles =0;
    if (qtyRows < qtyColumns) circles = (qtyRows +1)/2;
    else circles = (qtyColumns +1)/2;
    int arrayValue = 0;

    //1 круг = 4 отрезка
    for (int swit4 = 0; swit4 < circles; swit4++)
    {
        // 1 отрезок
        int i = 0 + swit4;
        int j = 0;
        for (j = 0 + swit4; j < qtyColumns - swit4; j++)
        {
            arrayValue++;
            RWTArray[i,j] = arrayValue;
        }

        // 2 отрезок
        j = qtyColumns - 1 - swit4;
        for (i = 1 + swit4; i < qtyRows- swit4;i++)
        {
            arrayValue++;
            RWTArray[i,j] = arrayValue;
        }

        // 3 отрезок
        i = qtyRows-1 - swit4;
        for (j = qtyColumns-2 - swit4; j > -1 + swit4; j--)
        {
            arrayValue++;
            RWTArray[i,j] = arrayValue;
        }

        // 4 отрезок 
        j = 0 + swit4;
        for (i = qtyRows - 2 - swit4; i > 0 + swit4; i--)
        {
            arrayValue++;
            RWTArray[i,j] = arrayValue;
        }
    }
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

int[,] myArray = new int[4,4];
PrintArray(myArray);
Console.WriteLine();
FillArrayByRounWalking(myArray);
PrintArray(myArray);