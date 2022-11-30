// вход цифра, обозначающая день недели,и проверяет является ли этот день выходным

string Week(int num)
{
    if(num <=5 && num>0)
        return "no";

    if(num>5 && num<7)
        return "yes";
    else 
        return "error";
}

Console.WriteLine("number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine(Week(first));
