// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit(int N)
// {
//     if (N < 0) N = -N;

//     int SumDigit = 0;
//     int digit = 0;
//             // int count = 0;               // для определения разрядности чисоа
//     for (int num = N; num >= 1; num /= 10)
//     {
//             // count++;                     // реализация задачи по определению
//             // Console.WriteLine(count);    // разрядности числа через for
//         digit = num % 10;
//         SumDigit = SumDigit + digit;
//     }
//     return SumDigit;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма цифр --> {SumDigit(number)}");


// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Stepen (int a, int b)
// {
//     int result = 1;
//     for (int num = 1; num <= b; num++)
//     {
//         result *= a;
//     }
// Console.WriteLine($"Число {a} в степени {b} = {result}");
// }

// Console.Write("Введите число A: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// Stepen (num_A, num_B);

/*
Задача 29: Напишите программу, которая создает массив заданного пользователем размера,
заполняет массив элементами от 1 до 99 и выводит их на экран.
*/
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)        // Метод - вывода массива на экран
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("\b\b]");
// }

// Console.Write("Введите длину нового массива: ");
// int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
// // int[] NewArr = CreateArray(LenghtOfArray);
// // Console.Write("Создан массив и записан в переменную NewArr");
// // PrintArray(NewArr);       // Для проверки вывода через промежуточную переменную
// Console.Write("Создан новый массив ");
// PrintArray(CreateArray(LenghtOfArray));     // Для проверки вывода "слёту"