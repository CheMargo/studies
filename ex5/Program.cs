/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8*/

System.Console.Write("введите трехзначное число: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    if (n>=100 && n < 1000)
    {
        int x = n % 10;
        System.Console.Write($"Последняя цифра вашего числа {x}");
    }
    else
    {
        System.Console.WriteLine("Вы ввели не трехзначное число");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не число!");
}