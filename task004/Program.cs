/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

for (int num2 = 1; num2 <= num1; num2++)
{

    if (num2 % 2 == 0)
    {
        Console.Write($"{num2} ");
    }
}
