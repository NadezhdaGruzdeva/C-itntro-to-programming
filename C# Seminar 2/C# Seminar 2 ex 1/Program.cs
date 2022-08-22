// Вывести случайное число из отрезка от 10 до 99 и показать наибольшую цифру числа

int num = new Random().Next(10, 100); //Задать случайное число от 10 до 99 включительно [a,b)
int a1 = num % 10;
int a2 = num /10;

Console.WriteLine(num);

int max = a1;
if (max < a2);
{
    max = a2;
}

Console.WriteLine(max);

