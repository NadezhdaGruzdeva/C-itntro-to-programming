// SНапишите программу, кот выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа
int num = new Random().Next(100, 1000); //Задать случайное число от 10 до 999 включительно [a,b)
int a1 = num / 100; //first figure
int a3 = num % 10; //Llast figure

Console.WriteLine(num);

int newNum = a1 * 10 + a3;


Console.WriteLine(newNum);

