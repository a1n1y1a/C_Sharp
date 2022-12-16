// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Tochka(double b1, double k1, double b2, double k2)
{
    double razn = k1 - k2;
    if (razn != 0)
    {
        double x = (b2 - b1)/razn;
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x};{y})");
    }


    else
       {
         Console.WriteLine("Точки пересечния нет");
       }
}

Tochka(int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()));

