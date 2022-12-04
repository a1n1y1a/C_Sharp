// выводит случайное трехзначное число и удаляет вторую цифру этого числа

int D(int num)
{
    Console.WriteLine(num);
    return num / 100*10 + num % 10;
}

 Console.WriteLine(D(new Random().Next (100,1000)));

//
//string SecondNum(int num)
//{
//if ((-1000<num && num<-99) || (num<1000 && num>99))
//    return $ "{num}" -> {num / 100 * 10 + num % 10}";
//return "The number is not three-digit!";
//}

//Console.WriteLine(SecondNum(int.Parse(Console.ReadLine())))