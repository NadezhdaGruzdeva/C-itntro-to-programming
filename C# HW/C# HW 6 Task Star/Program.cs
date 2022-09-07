//Напишите программу, которая реализует обход введенного двумерного массива, 
//начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)
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
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
    }
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

int[,] myArray = new int [7,10];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
RounWalkingThroughArray(myArray);




