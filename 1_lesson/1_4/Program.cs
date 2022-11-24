// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
Console.WriteLine($"{Math.Abs(N)}");

