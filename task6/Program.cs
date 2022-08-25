// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] FillArray(int minimum, int maximum)
{
    int[] array = new int [123];
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

Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");

int [] array = FillArray(minimum, maximum);

PrintArray(array);

int i = 0;
int count = 0;
 while (i<array.Length)
 {
    if (array[i]>=10 && array[i]<=99)
    {
        count++;
    }
    i++;
 }
Console.WriteLine($"В заднном массиве количество элементов из отрезка [10,99] равно {count}");