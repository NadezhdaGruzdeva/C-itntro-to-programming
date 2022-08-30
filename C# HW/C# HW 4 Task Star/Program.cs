// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - 
// высоту елочки и рисует ее в консоли звездочками.

// будем использовать пробелы и * 
// - примем что в строке терминала вмещается 99 символов, 
// 1) соотв в 1-ой строке 49 пробелов, 1*, 48 пробелов,
// 2) 49-1 пробел, 1+2*, 49-1 пробел и тд
// кол-во строк - высота елочки (единственная переменная)
//формула 1 строки = высотя елки

// Для строки 99 симв
//  void crismasTree (int hightTree)
// {
//     for (int i = 0; i < hightTree; i++)
//     {
//         Console.Write(new string (' ',49-i));
//         Console.Write(new string ('*',1+i*2));
//         Console.WriteLine(new string (' ',49-i));
//     }
// }
// Console.WriteLine ("Enter the hight of crismis tree ");
// int hight = int.Parse(Console.ReadLine());

// crismasTree(hight);

//Универсальный код при любом масштабе терминала
 void crismasTree (int hightTree)
{
    for (int i = 0; i < hightTree; i++)
    {
        Console.Write(new string (' ',hightTree - 1- i));
        Console.Write(new string ('*',1+i*2));
        Console.WriteLine(new string (' ',hightTree - 1- i));
    }
    if (hightTree>99) Console.WriteLine ("The tree is so hight/ Please change the scale of terminal to see it (CTR -)");
}
Console.WriteLine ("Enter the hight of crismis tree ");
int hight = int.Parse(Console.ReadLine());

crismasTree(hight);



