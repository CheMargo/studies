Console.WriteLine("Введите первое число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToInt32(Console.ReadLine());
double squ = Math.Pow (b, 2);

if (a == squ)
{
    Console.WriteLine ("является квадратом");
}
else
{
        Console.WriteLine ("не является квадратом");
}

