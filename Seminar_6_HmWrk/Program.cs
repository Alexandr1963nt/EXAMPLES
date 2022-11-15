// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 - тут в примере ошибка (реально 4)

void PrintArray(int[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

int CreateArrVarLengthPositiveNumber()
{
    int count = 1;
    int[] arr = new int[count];
    string stop = " Довольно";
    int PositiveNumber = 0;
    while (stop.ToLower() != "довольно")
    {
        Console.Write($"Укажи число: ");
        arr[count - 1] = Convert.ToInt32(Console.ReadLine());
        if (arr[count - 1] > 0) PositiveNumber++;
        Console.Write($"Ты устал? {stop.ToUpper() + "?"} - ");
        stop = Console.ReadLine();

        if (stop.ToLower() != "довольно")
        {
            count++;
            int[] temp = new int[count];
            for (int i = 0; i < count - 1; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }
    }
    Console.Write("Введен массив чисел -> ");
    PrintArray(arr);
    return PositiveNumber;
}
Console.WriteLine($"Положительных чисел в массиве всего: {CreateArrVarLengthPositiveNumber()}");


/*  // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2), y = k1 * x + b1; // y2 = k2 * x + b2; - для проверки
    Console.WriteLine($"Координаты точки пересечения: x = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}");
}

Console.Write("Внесите k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Внесите b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Внесите k2 - ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Внесите b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());

while (k2 == k1)
{
    Console.WriteLine($"При равных k1, k2 линии не пересекаются! Введите разные коеффициенты");
    Console.Write("Внесите новый k1 - ");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Внесите новый k2 - ");
    k2 = Convert.ToDouble(Console.ReadLine());
}

CrossPoint(k1, b1, k2, b2);

*/