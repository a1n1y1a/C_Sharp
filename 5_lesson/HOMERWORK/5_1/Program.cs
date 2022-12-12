// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

int SumChet(int[]array)
{
     int summa = 0;
    for (int i = 0; i < array.Length; i++)
   
    {
        if (array[i] % 2 == 0)
            summa = summa + 1;
    }
    return summa;
}
int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write(SumChet(arr_1));
