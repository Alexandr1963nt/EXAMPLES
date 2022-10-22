// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool check_palindrome5 (int num)
{
    int num1 = num/10000;
    int num2 = num/1000 - 10*(num/10000);
    int num3 = num/100 - 10*(num/1000);
    int num4 = num/10 - 10*(num/100);
    int num5 = num % 10;
    
    if (num1 == num5 & num2 == num4) return true;
    else return false;
}
// Ввод числа
Console.Write("Введите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// Проверка 5-значности числа
while (Math.Abs(number)/10000 < 1 | Math.Abs(number)/10000 > 9)
{
    Console.WriteLine($"{number} не 5-значное! Повторите ввод");
    Console.Write("Введите 5-значное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
// Проверка палиндрома и вывод результата
bool rezult = check_palindrome5 (number);
if (rezult) Console.Write($"Ура!! Число {number} является палиндромом");
else Console.Write($"Сорян. Число {number} не является палиндромом");

// Задача 21 ГОТОВО
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int square_of_section(int A, int B)
// {
//     int square = (A - B)*(A - B);
//     return square;
// }
// // Координаты точки A
// Console.WriteLine($"Введиите координаты точки A:");
// Console.Write("X = ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y = ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z = ");
// int az = Convert.ToInt32(Console.ReadLine());
// // Коордиаты точки B
// Console.WriteLine($"Введиите координаты точки B:");
// Console.Write("X = ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y = ");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z = ");
// int bz = Convert.ToInt32(Console.ReadLine());

// float distance = Convert.ToSingle(Math.Sqrt(square_of_section(ax, bx) + 
//                                             square_of_section(ay, by) +
//                                             square_of_section(az, bz)   ));

// Console.Write($"Расстояние A-B в 3D пространстве = ");
// Console.WriteLine($"{Math.Round(distance, 2)}");

// Задача 23 - ГОТОВО
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел
// от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void table_cub_num(int number)
{
    Console.Write($"{number} -> ");
    for (int num = 1; num <= number; num++)
    {
        if(num < number) Console.Write($"{num*num*num}, ");
        else Console.Write($"{num*num*num} ");
    }
}
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// table_cub_num(number);
