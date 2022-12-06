// 3. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

void Massiv(int n)
{
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(2);
Console.Write($"{array[i]}, ");
}
}

Console.WriteLine("Введите число:");
Massiv(int.Parse(Console.ReadLine()));
// ТК у нас в теле есть write то в конце мы не пишем write