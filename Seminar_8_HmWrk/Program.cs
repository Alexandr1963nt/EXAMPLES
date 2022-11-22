/*//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
*/
// //  Решение задачи 60
// void Print3dArray(int[,,] array)        // Метод - вывода массива на экран
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] Create3dArray(int x, int y, int z)  // Создать 3d массив
// {
//     int[,,] array = new int[x, y, z];

//     for (int i = 0; i < x; i++)
//     {
//         {
//             for (int j = 0; j < y; j++)
//                for (int k = 0; k < z; k++)
//                {
//                 array[i, j, k] = new Random(2*i+3*j+4*k).Next(10, 100);
//                }
            
//         }
//     }
//     return array;
// }

// Console.Write("How many rows will be thear in an array? - ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("How many columns will be thear in the array? - ");
// int width = Convert.ToInt32(Console.ReadLine());
// Console.Write("How many layers will be thear in the array? - ");
// int height = Convert.ToInt32(Console.ReadLine());

// int[,,] array3d = Create3dArray(length, width, height);

// Print3dArray(array3d);


/*// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
*/
//  Решение задачи 54
// void Print2dArray(int[,] array)        // Метод - вывода массива на экран
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ", ");
//         }
//         Console.WriteLine("\b\b ");
//     }
//     Console.WriteLine();
// }

// int[,] Create2dArray(int rows, int columns)  // Создать 2d массив
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         {
//             for (int j = 0; j < columns; j++)
//                 array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] SortRowsArrayDecrease(int[,] array) // Сортировка строк массива по убыванию
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             int maxPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, maxPosition]) maxPosition = k;
//             }
//             int temporary = array[i, j];
//             array[i, j] = array[i, maxPosition];
//             array[i, maxPosition] = temporary;
//         }
//     }
//     return array;
// }

// Console.Write("How many rows will be thear in an array? - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("How many columns will be thear in the array? - ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2dArray(rows, columns);
// Console.Write("\nИсходный массив \n ");
// Print2dArray(array);

// int[,] arraysort = SortRowsArrayDecrease(array);
// Console.Write("Сортировка строк массива по убыванию \n ");
// Print2dArray(arraysort);


/*//   Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
// //  Решение задачи 56 

// void Print2dArray(int[,] array)        // Метод - вывода массива на экран
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ", ");
//         }
//         Console.WriteLine($"\b\b    Сумма элементов строки  {i} -> {GetSummElementsRowOf2dArray(array, i)}");
//     }
//     Console.WriteLine();
// }

// int[,] Create2dArray(int rows, int columns)  // Создать 2d массив
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         {
//             for (int j = 0; j < columns; j++)
//                 array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int GetSummElementsRowOf2dArray(int[,] array, int rownumber) // Получить сумму елементов указанной строки 2d-массива
// {
//     int i = rownumber;
//     int sumElementsRow = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sumElementsRow += array[i, j];
//     }
//     return sumElementsRow;
// }

// int NumberMinRowOf2dArray (int[,] array)
// { int minRowNumber = 0;
// int sumElementsRow = GetSummElementsRowOf2dArray(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     if (GetSummElementsRowOf2dArray(array, i) < sumElementsRow) minRowNumber = i;
// }
//     return minRowNumber;
// }

// Console.Write("How many rows will be thear in an array? - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("How many columns will be thear in the array? - ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(rows, columns);
// Console.WriteLine("\nИсследуемый массив");
// Print2dArray(array);
// Console.Write($"Наименьшую сумму элементов имеет строка массива № {NumberMinRowOf2dArray (array)}\n ");


/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
// //  Решение задачи 62
// int[,] FillArraySpirally(int rows, int columns, int startElement)
// {
//     int[,] array = new int[rows, columns];
//     int arrayElement = startElement - 1;
//     int i = 0;
//     int j = 0;
//     for (int count = 0; count <= columns / 2; count++)
//     {
//         for (j = count; j < columns - count; j++)
//         {
//             arrayElement++;
//             array[i, j] = arrayElement;
//         }
//         j = columns - count - 1;
//         for (i = count + 1; i < rows - count; i++)
//         {
//             arrayElement++;
//             array[i, j] = arrayElement;
//         }
//         i = rows - count - 1;
//         for (j = j - 1; j >= count; j--)
//         {
//             arrayElement++;
//             array[i, j] = arrayElement;
//         }
//         j = j + 1;
//         for (i = i - 1; i >= count + 1; i--)
//         {
//             arrayElement++;
//             array[i, j] = arrayElement;
//         }
//         i = i + 1;
//     }
//     return array;
// }

// void Print2dArraySpirally(int[,] array) // Метод вывода спирального массива
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write("0");
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("How many rows will be thear in an array (from 1 to 10)? - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("How many columns will be thear in the array (from 1 to 9)? - ");
// int columns = Convert.ToInt32(Console.ReadLine());


// if (rows == columns | rows - columns == 1)
// {
//     Console.Write("Input the start element of the array? - ");
//     int startElement = Convert.ToInt32(Console.ReadLine());
//     int[,] filledArray = FillArraySpirally(rows, columns, startElement);
//     Console.WriteLine("\nThis array was created with your parameters");
//     Print2dArraySpirally(filledArray);
// }
// else
// {
//     Console.WriteLine("\n"+
//                         "Please input the same number of rows and columns, \n" +
//                         "or no more rows than columns by 1.\n");
// }
