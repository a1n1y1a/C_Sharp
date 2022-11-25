// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a=int.Parse(Console.ReadLine());
 
Console.WriteLine("Введите второе число:");
int b=int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c= int.Parse(Console.ReadLine());

int max=a;

if(a>=max) max=a;
if(c>max) max=c;
if(b>max) max=b;

Console.Write("max=");
Console.Write(max);

