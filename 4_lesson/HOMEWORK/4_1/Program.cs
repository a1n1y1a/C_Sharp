// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B. 
//Без модуля Math, используем цикл for.


int Vstep(int A, int B)
{

    int allA = 1;
    for (int i = 1; i <= B; i++)
    {
        allA = allA * A;

    }

    return allA;
}

Console.WriteLine("A");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("B");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(Vstep(first, second));


