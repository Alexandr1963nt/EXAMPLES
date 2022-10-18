// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int randNum = new Random().Next(100, 1000);

int ShowSecondDigit(int num)
{
int dec = num / 10; // Десятки
int hnd = num / 100; // Сотни
int SecondDigit = dec - hnd*10;
return SecondDigit;
}

int SecondDigit = ShowSecondDigit(randNum);
Console.WriteLine($"Second digit of number{randNum} is {SecondDigit}");


/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input any int number - ");
long num = Convert.ToInt64(Console.ReadLine());

long FindThirdDigit(long number)
{
    long remainder = 0; // остаток
    long count = 10;
    while ( remainder < number )
    {
    remainder = number % count;
    //Console.WriteLine($"Остаток = {remainder} count = {count}" ); //для отладки
    count = count*10; // определяю разрядность числа
    }
    long count1 = count / 1000; // Определяю коеффициент для нахождения числа в котором первая цифра = третьей ввеленного числа
    remainder = number % count1; // Нахожу остаток в котором первая цифра равна третьей
    count1 = count1/10; // Уменьшаю разрядность делителя на порядок
    //Console.WriteLine($"remainder вне цикла = {remainder} делитель = {count1}" );
    long ThirdDigit = remainder / count1; // нахожу первую цифру остатка. она соответсвует 3-ей цифре числа
    return ThirdDigit; 
}

if (num < 100) Console.WriteLine($"There isn't the third digit in the number {num}");
else 
{
    long ThirdDigit = FindThirdDigit(num);
    Console.WriteLine(ThirdDigit);
}
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Input a number of the day of the week - ");
int number_day = Convert.ToInt16(Console.ReadLine());

bool if_weekend (int number_day)
{
    if ( number_day == 6 || number_day == 7 ) return true;
    else return false;
}

while (number_day < 1 || number_day > 7)
{
    if (number_day > 7 || number_day ==0 )
    {
    Console.WriteLine($"The number {number_day} is not correct. Try againe!");
    Console.Write("Please input a correct number of the day of the week - ");
    number_day = Convert.ToInt16(Console.ReadLine());
    }
}

bool weekend = if_weekend (number_day);
if(weekend) Console.WriteLine($"День №{number_day} выходной? - Да");
else Console.WriteLine($"День №{number_day} выходной? - Нет");

*/