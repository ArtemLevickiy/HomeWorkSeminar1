Console.WriteLine ("Введите первое число: ");
int userNamber = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int userNamber2 = int.Parse(Console.ReadLine());

if ((userNamber2 * userNamber2) == userNamber)
{
    Console.WriteLine ("Квадрат второго числа равен первому числу");
}
else
{
    Console.WriteLine ("Квадрат второго числа НЕ равен первому числу");
}