// 1 type of methodes
void Method1()
{
    Console.WriteLine("Author: Nadezhda Gruzdeva");
}
Method1();

// 2 type of methodes
//1 argument
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text of message");

//2 arguments
void Method21(string msg, int count)
{
    int i = 1;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    Console.WriteLine(msg);
}
Method21("Text of message21", 4);

//explicit specifying an argument value
Method21(msg: "explicit specifying an argument value", count: 4);

// 3 type of methodes
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 4 type of methodes
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "a");
Console.WriteLine (res);


