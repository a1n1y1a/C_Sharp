// Void - console.writeline а не ритерн . консоль райтлайн выводит значение на экран
// string - return string пишем,когда возвращаем ТЕКСТ
//int - return int пишем,когда возвращаем целое число
//ритерн нужен чтобы возвращать значения для дальнейших манипуляций
// на вход число кратно ли оно одновременно 7 и 23

string Div(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
        return "кратно";

    else 
        return "некратно";
}

Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Div(number));
