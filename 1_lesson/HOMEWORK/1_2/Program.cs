// Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).

Console.WriteLine("Введите число:");
int num=int.Parse(Console.ReadLine());

double num_2 = num % 2;
if (num_2==0) 
{
    Console.WriteLine("число четное");
}

else
{
    Console.WriteLine("Число нечетное");
}
