int number = 512;
Console.WriteLine (number);
Console.WriteLine ("Введите число: ");
int userNamber = int.Parse(Console.ReadLine());

if (number % userNamber == 0)
{
Console.Write("Цифра кратна 512");
}
else
{
    int N = number % userNamber;
    Console.Write("Остаток = ");
    Console.Write(N);
}
