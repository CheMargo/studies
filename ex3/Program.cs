/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" */

/*Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
int count = -num;

while (count <= num)
{
    Console.Write($"{count}, ");
    count ++;

} */

Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = -num; i <= num; i++)
{
    System.Console.Write($"{i}, ");
}