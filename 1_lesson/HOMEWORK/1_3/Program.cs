// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
string num = Console.ReadLine();
int N = int.Parse(num);
int i = 0 ;
while (i<N-1)
{
    i+=2;
    Console.Write(i);
}



