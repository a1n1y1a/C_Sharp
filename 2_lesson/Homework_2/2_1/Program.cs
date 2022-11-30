// выводит случайное трехзначное число и удаляет вторую цифру этого числа

int D(int num)
{
    Console.WriteLine(num);
    return num / 100*10 + num % 10;
}

 Console.WriteLine(D(new Random().Next (100,1000)));

