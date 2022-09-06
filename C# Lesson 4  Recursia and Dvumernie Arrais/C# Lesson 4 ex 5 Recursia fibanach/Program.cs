// Fibanachi
//f(1)=1
//f(2)=1
//f(3)=2
//f(4)=3
//f(5)=5

double Fibanachi (int n)
{
    if(n == 1 || n == 2) return 1; 
    else return Fibanachi(n-1) + Fibanachi(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i} - {Fibanachi(i)}");
}
    