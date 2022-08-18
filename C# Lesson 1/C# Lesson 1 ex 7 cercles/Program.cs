Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30; //определили 3 вершины треугольника

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");    

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");   

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");   //вершины


int x = xa, y = xb;  //выбираем 2 любых точки

int count = 0;

while(count < 1000)
{
    int what = new Random().Next(0,3); // [0;3) 0 1 2 генерация случайных чисел (выбираем вершуну нужного нам треугольника)
    if (what == 0)    
    {
        x = (x + xa) / 2; 
        y = (y + ya) / 2;//находим середины между 2 точками
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; //count++ or count =+1
}