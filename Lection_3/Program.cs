
int[] arr = { 8, 5, 4, 3, 2, 6, 7, 1, 25 };

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("{");
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[count - 1]}"+"}");
    Console.WriteLine();
}

void SelectionSortIncrease(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortDecrease(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

Console.Write("Исходный массив  ");
PrintArray(arr);
SelectionSortIncrease(arr);
Console.Write("Сортировка вверх ");
PrintArray(arr);
SelectionSortDecrease(arr);
Console.Write("Сортировка вниз  ");
PrintArray(arr);

void metod1()
{ Console.Write("My name is ");}

metod1();

void metod2(string message)
{
Console.WriteLine(message); //— оператор, в скобках указан принятый аргумент.
}

metod2("Зашибок!");

void Metod21(string FirsName, string MiddleName, string LastName)
{
    Console.Write($"Меня зовут {LastName} {FirsName} {MiddleName}");
}
Metod21("А.", "Н.", "Трофименко");

int Metod3() //- не принимает никакие аргументы
{
return Convert.ToInt32(DateTime.Now.DayOfWeek); //- обязательное использование оператора return,
}
int year = Metod3(); //- вызываем метод, в левой части используем идентификатор
//переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);