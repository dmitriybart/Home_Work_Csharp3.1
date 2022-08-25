// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
int MaxIndex = size-1;
while (i < MaxIndex)
{
    Console.WriteLine($"Произведение {i+1} пары чисел равно {array[i]*array[MaxIndex]}");
    i++;
    MaxIndex--;
}