// 4. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

void Massiv(int[,] arr)
{
    int stolb = arr.GetLength(1);
    int raw = arr.GetLength(0);

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < stolb; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
int[,] Print(int raw, int stolb)
{
    int[,] arr = new int[raw, stolb];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < stolb; j++)
            arr[i, j] = new Random().Next(100, 1000);
    return arr;

}

//https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/