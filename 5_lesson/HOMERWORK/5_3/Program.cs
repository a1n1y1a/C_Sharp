// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] Mass(int size, int begin, int end)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(rnd.NextDouble() * (end + begin) - begin, 1);
    return arr;
}

void Raznica(double[] array)
{
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
            max = array[i];


        else if (array[i] <= min)
            min = array[i];

    }
    Console.Write($"Максимальное:{max}, Минимальное:{min}. ");
    Console.Write($"Разница : {max}-{min}={Math.Round(max-min,1)}");
}
double[] arr_1 = Mass(int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(arr_1);
Raznica(arr_1);

