//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    double row_size = arr.GetLength(0);
    double column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],6} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(rnd.NextDouble() * (to + from) - to, 1);
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column,
                           int.Parse(Console.ReadLine()),
                           int.Parse(Console.ReadLine()));
Print(arr_1);