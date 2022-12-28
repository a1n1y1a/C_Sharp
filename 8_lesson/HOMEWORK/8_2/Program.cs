// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void StrokaNaimSum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int num = 0;
    int min = 0;
    int a = 1000;
    for (int i = 0; i < row; i++)
    {
        num = 0;
        for (int j = 0; j < column; j++)
            num += arr[i, j];
        Console.Write($"{num,4} ");
        if (a > num)
        {
            a = num;
            min = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Искомая строка - {min + 1}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
StrokaNaimSum(arr_1);