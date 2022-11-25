/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
// Решение задачи 64
//  void ShowNumbersFromMtoN(int m, int n)
// {
//     if (Math.Max(m, n) > Math.Min(m, n)) ShowNumbersFromMtoN(Math.Max(m, n) - 1, Math.Min(m, n));
//     Console.Write($"{Math.Max(m, n)}, ");
// }
// Console.Write("\nВведите натуральное число M = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("\nИскомая последовательность -> \"");
// ShowNumbersFromMtoN(m, n);
// Console.Write("\b\b\"");
// Console.WriteLine("\n");

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
// решение задачи 66
// int SumBetweenMN(int m, int n)
// {     if (Math.Max(m, n) != Math.Min(m, n))
//     {
//         Console.Write($"{Math.Min(m, n)},");
// return SumBetweenMN(Math.Min(m, n) + 1, Math.Max(m, n)) + Math.Min(m, n);
//     }
//     else 
//     {   Console.Write($"{Math.Min(m, n)}\"");
//         return Math.Min(m, n);
//     }
// }
// Console.Write("\nВведите натуральное число M = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"\nСумма последовательности \"");
// int sumNumbers = SumBetweenMN(m, n);
// Console.Write($" = {sumNumbers}");
// Console.WriteLine("\n");


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29
*/

// Решение функция Аккермана
uint AckermanFunction(uint m, uint n)
{
    if (m == 0)
        return (n + 1);
    else
      if ((m > 0) & (n == 0))
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Write("\nФункция Аккермана очень быстрорастущая. Поэтому во избежание переполнения\n" +
                "введите неотрицательное целое число m (0 <= m <= 3) - ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("\nВведите неотрицательноечисло число n (0 <= n <= 11) - ");
uint n = Convert.ToUInt32(Console.ReadLine());

while (m < 0 | m > 3 | n < 0 | n > 11)
{
    Console.WriteLine($"\nЗначение функции Аккермана для m = {m}, n = {n} слишком велико!\n" +
                        "Выберите значения в рекомендуемых диапазонах\n");
    if (m < 0 | m > 3)
    {
        Console.Write("Введите новое число m в диапазоне (0 <= m <= 3) - ");
        m = Convert.ToUInt32(Console.ReadLine());
    }
    if (n < 0 | n > 11)
    {
        Console.Write("Введите новое число n в диапазоне (0 <= n <= 11) - ");
        n = Convert.ToUInt32(Console.ReadLine());
    }
}

uint valueAckFnctn = AckermanFunction(m, n);
Console.WriteLine($"\nСупер! Значение функции A(m = {m}, n = {n}) = {valueAckFnctn}\n");
