// ==работа в тексте
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы к большими К,
//а большие С заменить маленькими с.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+"Винценгероде, вы бы взяли приступом согласие"
+"прусского короля. Вы так красноречивы. Вы"
+"дадите мне чаю?";
Console.WriteLine(text);

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result =  result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text,' ','|'); // ' for char, "for string
Console.WriteLine(newText);
Console.WriteLine();

 newText = Replace(newText,'к','К'); // ' for char, "for string
Console.WriteLine(newText);
Console.WriteLine();

 newText = Replace(newText,'С','с'); // ' for char, "for string
Console.WriteLine(newText);
Console.WriteLine();
