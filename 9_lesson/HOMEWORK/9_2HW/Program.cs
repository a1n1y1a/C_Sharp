﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


void Numbers(int m, int n)
{
    if (m > n) return;
    Numbers((m + 1) + n);
}

Numbers(5, 8);





