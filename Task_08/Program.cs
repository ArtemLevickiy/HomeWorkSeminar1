int number = new Random().Next(9, 100);
Console.WriteLine (number);
int Max = 1;
int numberA = number % 10;
int numberB = number / 10;
if (numberA > Max) Max = numberA;
if (numberB > Max) Max = numberB;
Console.Write("Max = ");
Console.Write(Max);
