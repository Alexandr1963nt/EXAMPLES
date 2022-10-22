Console.Clear();
/*
//Функция максимум из 3 чисел
int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result; // ВАЖНО!! Я сразу не обратил внимание на обязательное наличие return в методе (функции) которая должна возвращать результат
}

int a1 = 2;
int b1 = 3;
int c1 = 4;

int a2 = 5;
int b2 = 77;
int c2 = 14;

int a3 = 777;
int b3 = 34;
int c3 = 141;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

// найти в мвссиве номер позиции заданного числа 4
int [] array = {2, 4, 5, 7, 4, 67, 34, 31, 99};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

*/
 
// Синтаксис массивов
// метод для заполнения массива
void FillArray(int[] Collection)
{
    int length = Collection.Length;
    int index = 0;
    while(index < length) 
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] Coll)
{
    int count = Coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(Coll[position]);
        position++;
    }
}
int IndexOf( int[]Collect, int find )
    {
        int count = Collect.Length;
        int ind = 0;
        int position = -1;

        while ( ind < count )
        {
            if(Collect[ind] == find)
            {
                position = ind;
                break;
            }
            ind++;
        }
        return position;
    }

int [] array = new int[8];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 444);

Console.WriteLine(pos);