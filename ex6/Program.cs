/*Удалить из трехзначного числа 2ую цифру*/
//abc = a*100 + b*10 + c
//
// Деление целочисленное                14 div 5 = 2   int/int => int
//         Обычное                      14 / 5 = 2.8   double / int => double
//                                                     int / double => double
//                                                     double / double => double
//         деление с остатком           14 mod 5 = 4   int % int => int

System.Console.Write("введите трехзначное число: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    if (n>=100 && n < 1000)
    {
        int a = n / 100;
        int b = (n / 10)%10;
        int c = n % 10;
        System.Console.Write($"Удаленная цифра вашего числа {n} = {b}, получение число = {a}{c}");
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
