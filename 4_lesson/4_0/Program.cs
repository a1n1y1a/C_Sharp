﻿// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

int SumNums(int num) //выдает сумму,поэтому пишем int ,число выходит целое,поэтому пишем int num
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;

}
Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));//могу сюда приписать плюс 100 и результат будет пплюс 100
//вызывваем программу,пишем консоль врайтлайн потому что в теле у нас ритерн

//заходит строка 7,парс делает из него число, потом сам намс делает ...