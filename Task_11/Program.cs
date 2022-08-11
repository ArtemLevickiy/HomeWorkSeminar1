int number = new Random().Next(1, 1000);
Console.WriteLine(number);
int digitIndex = 2;
int digit      = number.ToString()[digitIndex] - '0';
if (number < 100)
{
    Console.Write("Нет третей цифры");
}
else
{
    Console.Write(digit);
}

