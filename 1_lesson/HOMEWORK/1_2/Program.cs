// Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).

Console.WriteLine("Введите число:");
int num=int.Parse(Console.ReadLine());

if (num/2)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}