// Задача со звездочкой: Пользователь вводит скобочные последовательности. 
// В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, 
// составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена


//https://youtu.be/OTudUhiLNvk
// # D. Правильная скобочная последовательность
// pair = {
//     '}': '{',
//     ')': '(',
//     ']': '['
// }

// Алгоритм:
// 1. Пробегаемся по всем символам строки
// 1.1. Если это открывающаяся скобка, закидываем символ в стек
// 1.2. Если нет, проверяем является ли элемент закрывающейся скобкой
// 1.2.1. Если это закрывающаяся скобка, проверяем, есть ли в стеке что-нибудь
// 1.2.1.1 Если в стеке ничего нет, то последовательность неправильная
// 1.2.1.2. Если в стеке что-то есть, сверяем верхний элемент стека с текущим символом на предмет соответствия типа скобок
///1.2.1.2.1. Если скобки соответствует то переходим к следующиму символу в цикле
///1.2.1.2.1. Если скобки не соответствует то прерывем цикл - последовательность некорректная
// 1.2.2. Если это не скобка, переходим к следующему элементу
//2. Проверяем  статус результата проверки последовательности на данном этапе и пустой ли сейчас стек
//2.1. Если статус результата проверки последовательности на данном этапе - корректно и в стеке ничего не осталось, то
    //конечные результат - ОК
//2.2. Если что-то осталось в стеки или текущий результат проверке НЕ ОК, то последовательность не корректна

void СheckBrackets(string braketsStr)
{
    var openBrackets = new Stack<string>();
    bool result = true;
    //1. Пробегаемся по всем символам строки
    for (int i = 0; i < braketsStr.Length; i++)
    {
        //1.1. Если это открывающаяся скобка, закидываем символ в стек
        if (braketsStr[i] == '{' || 
            braketsStr[i] == '(' || 
            braketsStr[i] == '[')
        {
            openBrackets.Push(Convert.ToString(braketsStr[i]));
            //Console.WriteLine($"Iteration {i}, checked symbol {braketsStr[i]} is correct {result}");
            continue;
        } 
        // 1.2. Если нет, проверяем является ли элемент закрывающейся скобкой
        else
        {
            //1.2.1. Если это закрывающаяся скобка, проверяем, есть ли в стеке что-нибудь
            if (braketsStr[i] == '}' || 
                braketsStr[i] == ')' || 
                braketsStr[i] == ']')
            {
                // 1.2.1.1 Если в стеке ничего нет, то последовательность неправильная
                if (openBrackets.Count == 0)
                {
                    result = false;
                    //Console.WriteLine($"Iteration {i}, checked symbol {braketsStr[i]}, is correct {result}");
                    break;
                }
                // 1.2.1.2. Если в стеке что-то есть, сверяем верхний элемент стека с текущим символом 
                //на предмет соответствия типа скобок
                else
                {
                    char lastOpenBracket = Convert.ToChar(openBrackets.Pop());
                    if (lastOpenBracket  == '{' & braketsStr[i] == '}' ||
                        lastOpenBracket  == '[' & braketsStr[i] == ']' ||
                        lastOpenBracket  == '(' & braketsStr[i] == ')'
                        )
                    {
                        result = true;
                        //Console.WriteLine($"Iteration {i}, checked symbol {braketsStr[i]}, symbol from steck is {lastOpenBracket} is correct {result}");
                        continue;
                    }
                    else
                    {
                        result = false;
                        //Console.WriteLine($"Iteration {i}, checked symbol {braketsStr[i]}, symbol from steck is {lastOpenBracket} is correct {result}");
                        break;
                    }
                }          
            }
            // 1.2.2. Если это не скобка, переходим к следующему элементу
            else
            {
                //Console.WriteLine($"Iteration {i}, checked symbol {braketsStr[i]} is correct {result}");
                continue;
            }       
        }
    }
    //Console.WriteLine($"is correct {result}");
    
    //2. Проверяем  статус результата проверки последовательности на данном этапе и пустой ли сейчас стек
    if (result == true & openBrackets.Count == 0)
    {
        Console.WriteLine("The bracket sequence is correct");
        //Console.WriteLine($" is correct {result}");
    }
    else
    {
        Console.WriteLine("The bracket sequence is incorrect");
        //Console.WriteLine($"is correct {result}");
    }
    Console.WriteLine(openBrackets);
}

Console.Write("Enter bracket sequence ");
string sequence = Console.ReadLine();
СheckBrackets(sequence);

