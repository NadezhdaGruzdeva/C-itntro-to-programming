// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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



int[,,] MyArray = Get3xArrayWithUniqueValues(3,3,3,10,99);
Console.WriteLine("3x array");
Print3xArrayByRows(MyArray);


