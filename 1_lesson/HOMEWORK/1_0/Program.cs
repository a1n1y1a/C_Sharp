//Напишите программу, которая на вход принимает
//два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1");
int num1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2=int.Parse(Console.ReadLine());

int max = num1;

if (num2>max)
{
    Console.WriteLine("Число 2 больше числа 1");
}
else if(num2<max)
{
    Console.WriteLine("Число 1 больше числа 2");
}
else
{
    Console.WriteLine("Числа равны");
}
