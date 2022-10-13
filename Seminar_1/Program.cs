// Задача 1
Console.Clear();
/*
Console.Write("Введи число - ");
//int num = 67;
//string num = Console.ReadLine();
//int num = Console.Read();

int num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ты ввел - " + num + " И это гуд!");
//Console.WriteLine($"Ты ввел {num} И это гуд!");

int result = num * num;
Console.WriteLine($"Квадрат числа {num} равен {result}");
*/
// Задача 2
/*Console.Write("Введи число - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число - ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == num1 * num1)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else
{Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
}
*/

// Залача 3
/*
Console.Write("Input int number");
int num = Convert.ToInt32(Console.ReadLine());
int current = (-1) * num;

while( current <= num)
{
Console.Write(current + " ");
current++;
} */

// Задача 4 
// Написать прогу, которая принимает на вход 3-значное яяисло и выдаёт его последнюю цифру

Console.Write("Внести 3-значное целое число - ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine($"Последняя цифра {num} равна {result}");