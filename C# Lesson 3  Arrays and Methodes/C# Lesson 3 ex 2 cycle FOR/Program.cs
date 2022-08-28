// 4 type of methodes
string Method4(int count, string text)
{
    // int i = 0;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    return result;
}
string res = Method4(10, "a");
Console.WriteLine (res);
