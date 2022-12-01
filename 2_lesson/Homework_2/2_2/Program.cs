// вывод третьей цифры заданного числа или сообщает,что ее нет

void TN(int num)

{
    Console.Write($"{num}->");
    if (num<99)
    {
        Console.WriteLine("Число не имеет третьей цифры. Введите другое число.");
        return;
    }
    while (num>999) num/=10;
    Console.WriteLine(num%10);
}
Console.WriteLine ("Введите число");
TN(int.Parse(Console.ReadLine()));