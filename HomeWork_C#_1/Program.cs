//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Задача 2: Напиcать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("");
Console.WriteLine("Введите два числа для сравнения:");
Console.Write("Число №1 - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число №2 - ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
    Console.WriteLine($"min = {num2}");
}
else
{
    if(num1 == num2)
    {
        Console.Write( "Введены равные числа");
    }
        else
            {
                 Console.WriteLine($"max = {num2}");
                 Console.WriteLine($"min = {num1}");
            }
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Задача 4: Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
Console.Write("Сколько чисел будем сравнивать? Рекомендуем ограничиться тремя ;) - ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
int i = 0;
while (i < size)
{
    Console.Write($"Введите число №{i+1} - ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
i = 0;
int max = nums[0];
while (i < size)
{
    if(nums[i] > max)
    {
        max = nums[i];
    }
    i++;
}
Console.WriteLine($"Максимальное число = {max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6: Написать программу, которая на вход принимает число и выдаёт,");
Console.WriteLine("является ли оно чётным (делится ли оно на два без остатка)");
Console.WriteLine("");
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
if(result == 1)
{
    Console.WriteLine($"Число {num} является нечетным");
}
else
{
    Console.WriteLine($"Число {num} является четным");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.Write("Введите целое число - ");
int Number = Convert.ToInt32(Console.ReadLine());
//8 -> 2, 4, 6, 8
int EvenNumber = 2;
while(EvenNumber <= Number)
{
if ( EvenNumber == Number | EvenNumber == Number-1 )
{ 
     Console.Write(EvenNumber);
}
else
{
    Console.Write($"{EvenNumber}, ");
}
EvenNumber = EvenNumber + 2;    
} 