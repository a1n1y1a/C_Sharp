//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next( );
        Console.Write($"{array[i]}, ");
    }
}
Console.WriteLine("Введите число:");
Massiv(int.Parse(Console.ReadLine()));

