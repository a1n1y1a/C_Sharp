// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int N = int.Parse(num);
int Nen = -N;

while (Nen<=N)
{
    Console.Write($"{Nen}");
    Nen +=1;
}

