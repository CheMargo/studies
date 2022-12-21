/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


System.Console.Write("введите трехзначное число: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    if (n>=100 && n < 1000)
    {
        int a = n / 100;
        int b = (n / 10)%10;
        int c = n % 10;
        System.Console.Write($"Удаленная цифра вашего числа {n} = {a} и {c}, получение число = {b}");
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