// преобразовать десятичное число в двоичное

int ConsoleInputNumber(int indexFrom1ConsoleInputNumber)
{
    Console.Write($"Enter {indexFrom1ConsoleInputNumber} number = ");
    int valueConsoleInputNumber = int.Parse(Console.ReadLine());
    return valueConsoleInputNumber;
}

string TransferToBinar(int valueTransferToDvoichnoe)
{
    string BinaryNumTransferToBinar = String.Empty;

    while (valueTransferToDvoichnoe > 0)
    {
        if (valueTransferToDvoichnoe % 2 == 1)
        {
            BinaryNumTransferToBinar += "1";
        }
        else 
        {
            BinaryNumTransferToBinar += "0";
        }
        valueTransferToDvoichnoe = valueTransferToDvoichnoe / 2;
    }
    string ReverseTransferToBinar = String.Empty;
    for (int i = BinaryNumTransferToBinar.Length-1; i >=0 ; i--)
    {
        ReverseTransferToBinar += BinaryNumTransferToBinar[i];
    }
    return ReverseTransferToBinar;
}

int num = ConsoleInputNumber(1);
Console.WriteLine(TransferToBinar(num));

