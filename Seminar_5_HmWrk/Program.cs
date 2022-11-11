// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// /*

int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

void CountEvenNumbers(int[] array)  // Счётчик чётных чисел
{
    int CountEvNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) CountEvNum++;
    }
    Console.WriteLine($"Чётных чисел в массиве -> {CountEvNum}");
}

Console.Write("Введите длину нового массива: ");
int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(LenghtOfArray);
PrintArray(array);
CountEvenNumbers(array);

// */



// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

void SumNumOnOddPositions (int [] array)
{
    int SumNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) SumNum += array[i];
    }
    Console.Write($"Сумма элементов на нечетных позициях = {SumNum}");
}

Console.Write("Введите длину нового массива: ");
int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(LenghtOfArray);
PrintArray(array);
SumNumOnOddPositions (array);
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] CreateArray(int length)   // Метод - заполнение массива заданной длины
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 100) + Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\b]");
}

void DifferenceMaxMin(double[] array)   // Метод нахождения мин,макс и рассчёта (макс-мин)
{
    int max_i = 0;
    int min_i = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max_i]) max_i = i;
        else
        {
            if (array[i] < array[min_i]) min_i = i;
        }
    }
    Console.Write($"Max = {array[max_i]}  Min = {array[min_i]}. ");
    Console.WriteLine($"Разница (Max - Min) = {Math.Round(array[max_i] - array[min_i], 2)}");

}

Console.Write("Введите длину нового массива: ");
int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(LenghtOfArray);
PrintArray(array);
DifferenceMaxMin(array);

*/