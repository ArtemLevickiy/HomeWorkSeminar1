Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = -number;
while(startNumber <= number)
{
    Console.Write(startNumber + " ");
    startNumber++;
}