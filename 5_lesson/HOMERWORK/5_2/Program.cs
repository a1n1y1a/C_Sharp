// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 26

//[-4, -6, 4, 6] -> 0


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
        arr[i] = new Random().Next(10, 100);
    return arr;
}

int Sum2(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (i % 2 == 0)
            summa = summa + array[i];
    }
    return summa;
}
int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write(Sum2(arr_1));