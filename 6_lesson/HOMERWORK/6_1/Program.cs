// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int M(int num)
{
    int count = 0;
    for (int i = 0; i <= num; i++)
    {
        Console.Write($"Число{i}: ");
        int chislo = int.Parse(Console.ReadLine());
        if (chislo > 0) count++;
    }
    return count;
}

int chislo = int.Parse(Console.ReadLine());
Console.WriteLine($"Чисел больше 0 - {M(chislo)}");

