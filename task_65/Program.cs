// Задача 65.
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NumbersFromMtoN(int m, int n)
{
    if (n > m) NumbersFromMtoN(m, n - 1);
    Console.Write($"{n} ");
    if (m > n) NumbersFromMtoN(m, n + 1);
}
NumbersFromMtoN(10, 1);

