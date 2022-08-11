int number = new Random().Next(1, 1000);
Console.WriteLine(number);

if (number > 99)
{
    int digitIndex = 2;
    int digit      = number.ToString()[digitIndex] - '0';
    Console.Write(digit);
}
else
{
    Console.Write("Нет третей цифры");
}

