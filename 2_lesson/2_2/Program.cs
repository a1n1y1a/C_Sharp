// заходит два числа кратно ли одно второму если не кратно то выводит остаток


string crat(int num, int num_2)
{
    if(num % num_2 == 0)
        return "кратно";

    else 
        return $"некратно, остаток= {num % num_2}";
}

Console.WriteLine("1 chislo");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("2 chislo");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(crat(first,second));
