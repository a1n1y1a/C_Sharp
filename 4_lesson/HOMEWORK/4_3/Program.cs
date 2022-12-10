//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next();
        Console.Write($"{array[i]}, ");
    }
}
Console.WriteLine("Введите число:");
Massiv(int.Parse(Console.ReadLine()));

//

void Print(int[] arr)
{
    int size = arr.Lenght;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();

}

int[] Eightmass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new.Random().Next(1, 100);
    return arr;
}

int[] arr_1 = Eightmass(int.Parse(Console.ReadLine()));
Print(arr_1);
int[] arr_2 = Eightmass(int.Parse(Console.ReadLine()));
Print(arr_2);

}