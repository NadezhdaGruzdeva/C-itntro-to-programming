//Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
    // III -> 3
    // LVIII -> 58
    // MCMXCIV -> 1994

// Символы римского счисления
    // 1	I	лат. unus, unum
    // 5	V	лат. quinque
    // 10	X	лат. decem
    // 50	L	лат. quinquaginta
    // 100	C	лат. centum
    // 500	D	лат. quingenti
    // 1000	M	лат. mille

// Для правильной записи больших чисел римскими цифрами необходимо сначала 
// записать число тысяч, затем сотен, затем десятков и, наконец, единиц.

//Правило сложения и вычитания при переводе чисел в арабские
    // При записи чисел в римской системе счисления меньшая цифра может стоять справа от большей; 
    // в этом случае она прибавляется к ней. Например, число 283 по-римски записывается как CCLXXXIII, 
    // то есть 100+100+50+30+3=283. Здесь цифра, изображающая сотню, повторена два раза, 
    // а цифры, изображающие соответственно десяток и единицу, повторены по три раза.

//АЛГОРИТМ
    // 1) Вводим римское число как строку string
    // 2) Переводим эту строку в массив с символовами char
    // 3) В новый массив (с целочисл зн) переносим переведенный символы римск счисления 
         // в соотв числа арабск сч int
    // 4) Пробегаемся по элементам нового массива, сравнивая их на предмет "правила сложения и вычитания
         // (см. строку 17)
    // 5) В том же цикле (п.4) переводим скорректированные значения элементов массива 
         // в значения для получения римского числа.
    // 6) В том же цикле (п.4) суммируем значения, полученные в п.5 и получаем арабское число


void RomanToArabicNumber ()
{
        // 1) Вводим римское число как строку string
    Console.WriteLine("Enter roman number ");
    string strRomanNumber  = Console.ReadLine();

    // // 2) Переводим эту строку в массив с символовами char - не нужно, строка и так массив
    // char[] chRomanNumber = new char[strRomanNumber.Length]; 
    // for (int i = 0; i < strRomanNumber.Length; i++) 
    // { 
    //     chRomanNumber[i] = strRomanNumber[i]; 
    // } 
    // Console.WriteLine(String.Join(" ", chRomanNumber));

    // 3) В новый массив (с целочисл зн) переносим переведенный символы римск счисления 
    // в соотв числа арабск сч int
    int[] intRomanNumber = new int[strRomanNumber.Length]; 
    for (int i = 0; i < strRomanNumber.Length; i++) 
    { 
        if (strRomanNumber[i] == 'I')
        {
            intRomanNumber[i] = 1; 
        }
        else if (strRomanNumber[i] == 'V')
        {
            intRomanNumber[i] = 5; 
        }
        else if (strRomanNumber[i] == 'X')
        {
            intRomanNumber[i] = 10; 
        }
        else if (strRomanNumber[i] == 'L')
        {
            intRomanNumber[i] = 50; 
        }
        else if (strRomanNumber[i] == 'C')
        {
            intRomanNumber[i] = 100; 
        }
        else if (strRomanNumber[i] == 'D')
        {
        intRomanNumber[i] = 500; 
        }
        else if (strRomanNumber[i] == 'M')
        {
            intRomanNumber[i] = 1000; 
        }
        else
        {
        Console.WriteLine("The Romanian number has entered incorrectly");
        break;
        }

    } 
    // Console.WriteLine(String.Join(" ", intRomanNumber));

    // 4) Пробегаемся по элементам нового массива, сравнивая их на предмет "правила сложения и вычитания
        // (см. строку 17)
    // 5) В том же цикле (п.4) переводим скорректированные значения элементов массива 
        // в значения для получения римского числа.
    // 6) В том же цикле (п.4) суммируем значения, полученные в п.5 и получаем арабское число

    int j = 0;
    int arabNumber = 0;
    while (j < intRomanNumber.Length)
    {
        if (j == intRomanNumber.Length - 1) 
        {
            arabNumber += intRomanNumber[j];
            j++;
        }
        else
        {
            if (intRomanNumber[j] >= intRomanNumber[j+1])
            {
                arabNumber += intRomanNumber[j];
                j++;
            }
            else
            {
                arabNumber += intRomanNumber[j+1] -intRomanNumber[j];
                j +=2;
            }
        }
    }
    Console.WriteLine($"Romanian number {strRomanNumber} is equal Arab number {arabNumber}");
}

RomanToArabicNumber();