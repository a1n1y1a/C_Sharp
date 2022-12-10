// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int n)
{
    int count = 0;
    int summa = 0;
    while (n > 0)
    {
        summa = summa + n % 10;
        n = n / 10;
        count++;
    }

    return summa;

}
Console.WriteLine((SumNum(int.Parse(Console.ReadLine()))));


// double DigitSum(int num)
//{
//    string n=num ToString();
//  int length=n.Length;
//  double sum=0;
//
//  for (int i=0; i<length ;i++)
//  {
//      double m=char.GetNumericValue(n[i]);
//      sum+=m;
//  }

//  return sum;
//}
//Console.WriteLine(DigitSum(int.Parse(Console.ReadLine())));



