﻿// Задайте значение N. Напишите прошрамму,которая выведет 
//все натуральные числа в промежутке от 1 до N при помощи рекурсиию

void Chisla(int a)
{
    if (a == 0) return;
    Chisla(a - 1);
    Console.Write($"{a}");
}
Chisla(9);
