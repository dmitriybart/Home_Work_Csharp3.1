// Найти сумму чисел одномерного массива стоящих на нечетной позиции

// НАЙДЕННА СУММА ЧИСЕЛ ПО НЕЧЁТНЫМ ПОЗИЦИЯМ ДЛЯ ПОЛЬЗОВАТЕЛЯ, ЕСЛИ ДЛЯ НЕЧЁТНОЙ ПОЗИЦИИ ДЛЯ ПК, ТО ПОКАЗАЕЛЬ НА 39 СТРОКЕ "i=1"

int [] FillArray(int size, int minimum, int maximum)
{
    int[] array = new int [size];
    int index = 0;
    var random = new Random();
    while (index < array.Length)
    {
        array[index] = random.Next(minimum, maximum+1);
        index++;
    }
    return array;
}

void PrintArray(int[] collection)
{
    int position = 0;
    while (position < collection.Length)
{
    Console.Write(collection[position] +" ");
    position++;
}
Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");

int [] array = FillArray(size, minimum, maximum);

PrintArray(array);

int i = 0;
int sum = 0;
while (i < size)
{
    sum=sum+array[i];
    i=i+2;
}
Console.WriteLine($"В заднном массиве сумма чисел, стоящих на нечётной позиции равна {sum}");