// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число 1");
int num1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2=int.Parse(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("Да");
}

else
Console.WriteLine("Нет");

