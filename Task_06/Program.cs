Console.Write("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());
if(number < 1000)
{
    if(number > 99)
    {
     int lastDigit = number % 10;
    Console.WriteLine("Последняя цифра " + lastDigit);
    }  
}  