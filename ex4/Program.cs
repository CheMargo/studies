Console.Write("введите  трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int x = num % 10;
Console.Write($"последняя цифра: {x}");