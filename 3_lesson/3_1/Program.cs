// по заданному номеру чевтерти выводит диапозон возможных кооринат точек в жтой четверти икс и игрик

void Quarters(string a)
{
    if (a == "I")
    Console.WriteLine ("x>0 and y>0");

     else if (a == "II")
    Console.WriteLine ("x<0 and y>0"); 

    else if (a == "III")
    Console.WriteLine ("x<0 and y<0"); 

    else if (a == "IV")
    Console.WriteLine ("x>0 and y<0"); 

    else 
    Console.WriteLine("error");
}
Quarters(Console.ReadLine());