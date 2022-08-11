int number = new Random().Next(99, 1000);
Console.WriteLine (number);
var str = number.ToString();
number = int.Parse(str.Remove(str.Length - 2,1));
Console.Write("Без второй цифры =");
Console.Write(number);