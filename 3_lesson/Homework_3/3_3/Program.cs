// Напишите программу, которая ппринимает на вход число N и выводит таблицу кубов чисел от 1 до N

void Kub (int N)
{
    int i = 0;
    double pere ;
    while (i < N)
    {
        i+=1;
        if (i == (N))
        {
            pere=Math.Pow(i,3);
            Console.Write($"{pere}");
        }
       else
       {
         pere=Math.Pow(i,3);
            Console.Write($"{pere},");
       }
    }
}
Console.WriteLine ("введите число");
int chislo = int.Parse (Console.ReadLine());
Kub(chislo);
