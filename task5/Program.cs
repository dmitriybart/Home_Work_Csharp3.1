// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] FillArray(int size)
{
    int[] array = new int [size];
    int index = 0;
    var random = new Random();
    while (index < array.Length)
    {
        array[index] = random.Next(100, 1000);
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

int [] array = FillArray(size);
PrintArray(array);

int  i=0;
int countEven=0;
int countOdd=0;
while (i<size)
{
    if (array[i]%2==0)
    {
        countEven++;
    }
    else
    {
        countOdd++;
    }
    i++;
}
Console.WriteLine($"В заднном массиве количество четных чисел равно {countEven}, а нечетных равно {countOdd} ");


