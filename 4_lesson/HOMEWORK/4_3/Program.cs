//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Mas(int n)
{
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
array[i] = Console.WriteLine ("Введите элементы массива") ;
Console.Write($"{array[i]}, ");
}
}

Console.WriteLine("Введите элементы массива:");
M(int.Parse(Console.ReadLine()));