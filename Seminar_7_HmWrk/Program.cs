
/*// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double GetRandomDoubleIntoRange(short minValue, short maxValue)  // Метод генерации случайного действительного числа в заданном диапазоне
{
    Random rnd = new Random();
    double value = rnd.Next(minValue, maxValue) + rnd.NextDouble();
    return value;
}

double[,] Create2dArrayWhithRandomDouble(short rows, short columns, short minval, short maxval)
{
    double[,] array = new double[rows, columns];
    for (short i = 0; i < rows; i++)
    {
        {
            for (short j = 0; j < columns; j++)
                array[i, j] = GetRandomDoubleIntoRange(minval, maxval);
        }
    }
    return array;
}
void Print2dArrayWhithRandomDouble(double[,] array)        // Метод - вывода массива на экран
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " | ");
        }
        Console.WriteLine("\b\b\b  ");
    }
}

Console.Write("How many rows is in the array? - ");
short rows = Convert.ToInt16(Console.ReadLine());
Console.Write("How many columns is in the array? - ");
short columns = Convert.ToInt16(Console.ReadLine());
Console.Write("Input the minimum integer value of the array range - ");
short minval = Convert.ToInt16(Console.ReadLine());
Console.Write("Input the maximum integer value of the array range - ");
short maxval = Convert.ToInt16(Console.ReadLine());

double[,] array_new = Create2dArrayWhithRandomDouble(rows, columns, minval, maxval);
Print2dArrayWhithRandomDouble(array_new);
*/

/*// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print2dArray(int[,] array)        // Метод - вывода массива на экран
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine("\b\b ");
    }
    Console.WriteLine();
}

bool CheckElementExist(int[,] array, short rowindex, short columnindex)
{
    if (array.GetLength(0) - 1 >= rowindex & rowindex >= 0 &
        array.GetLength(1) - 1 >= columnindex & columnindex >= 0) return true;
    else return false;
}

int GetArrayElementByIndex(int[,] array, short row, short column)
{int FindElement = 0;
    for (short i = 0; i < array.GetLength(0); i++)
    {
        for (short j = 0; j < array.GetLength(1); j++)
        {
            if (i == row & j == column) FindElement = array[i, j];
        }
    }
    return FindElement;
}

int[,] SourceArrayForSearch =  new int[,]
                                {
                                    {1,4,7,2,6,3},
                                    {5,9,2,8,4,2},
                                    {3,4,1,5,7,2},
                                    {6,7,3,2,6,9},
                                    {8,5,7,6,1,3}
                                };

Print2dArray(SourceArrayForSearch);

Console.Write("Input the row index i = ");
short rowindex = Convert.ToInt16(Console.ReadLine());
Console.Write("Input the column index j = ");
short columnindex = Convert.ToInt16(Console.ReadLine());

bool ElementAvailability = CheckElementExist(SourceArrayForSearch, rowindex, columnindex);
if (ElementAvailability)
{
    int ElementByIndex = GetArrayElementByIndex(SourceArrayForSearch, rowindex, columnindex);
    Console.WriteLine($"Good! Element with index [{rowindex}, {columnindex}] = {ElementByIndex}");
}
else Console.WriteLine($"Warning! Element with index [{rowindex}, {columnindex}] doesn't exist!");
*/

/*// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2dArray(int rows, int columns)  // Создать 2d массив
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        {
            for (int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print2dArray(int[,] array)        // Метод вывод 2d массива на экран
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("\b ");
    }
    Console.WriteLine();
}
double[] GetArithmeticMeanArrayColumn(int[,] array) // Метод. Получить 1d массив средних арифметических значений по столбцам 2d-массива
{
    double[] ArithmeticMeanArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        double SummaColumnElements = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count++;
            SummaColumnElements += array[i, j];
            ArithmeticMeanArray[j] = SummaColumnElements / count;
        }
    }
    return ArithmeticMeanArray;
}
void Print1dArray(double[] array)        // Метод - вывод 1d массива на экран
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} | ");
    }
    Console.WriteLine("\b\b\b ]\n");
}

Console.Write("How many rows is in the array? - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns is in the array? - ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] sourceArray = Create2dArray(rows, columns);

Print2dArray(sourceArray);

double[] resultarray = GetArithmeticMeanArrayColumn(sourceArray);

Console.Write($"There is Array of arithmetic means for the 2d-array columns - ");
Print1dArray(resultarray);

*/

