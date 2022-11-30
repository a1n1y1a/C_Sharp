// Принимает на вход трехзначноетчисло,а на выходе показывает вторую цифру этого числа

int SecondNumber(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10;
}

 Console.WriteLine(SecondNumber (new Random().Next (100,1000)));

