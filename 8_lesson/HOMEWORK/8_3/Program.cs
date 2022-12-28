// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] Proizvedenie(int arr_1, int arr_2)
{
    int row_size = arr_1.GetLength(0);
    int column_size = arr_1.GetLength(1);
    int[,] matrica = new int[row_size, column_size];
    if (row_size != arr_2.GetLength(0) || column_size != arr_2.GetLength(1)) return matrica;

    for (int i = 0; i < row; i++)

        for (int j = 0; j < column; j++)

            matrica[i, j] = arr_1[i, j] * arr_2[i, j];
    return matrica;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
int[,] arr_1 = Proizvedenie(arr_1, arr_2);

