// Напишите программу, которая на вход принимает пятизначное число и проверяет является ли оно палиндромом 
string Palindrom(int num)
{
    Console.Write($"{num}->");

    if (num > 9999 && num < 100000)
    {
        if (num / 10000 % 10 == num % 10 && num / 1000 % 10 == num / 10 % 10)

            return "Число является палиндромом";

    }

    return "Число не является палиндромом";

}

Console.WriteLine("введите число");
int chislo = int.Parse(Console.ReadLine());
Palindrom(chislo);

