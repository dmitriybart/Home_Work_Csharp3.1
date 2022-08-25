// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

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
void MaxMinArray (int[] CountArray)
 {
    int index = 0;
    int max = CountArray[index];
    int min = CountArray[index];
    while (index < CountArray.Length)
    {
        if (CountArray[index]> max)
        {
            max = CountArray[index];
        }
        if (CountArray[index]< min)
        {
            min = CountArray[index];
        }
        index++;
    }
Console.WriteLine ($"Максимальное число массива равно {max}, а минимальное число равно {min}");
 }
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");

int [] array = FillArray(size, minimum, maximum);

PrintArray(array);
MaxMinArray(array);

