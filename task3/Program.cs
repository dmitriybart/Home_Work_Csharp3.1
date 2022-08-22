// Написать программу замену элементов массива на противоположные
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
void ReArray(int[] replacement)
{
    int i = 0;
    while (i < replacement.Length)
    {
        replacement[i]=-replacement[i];
        
        i++;
    }
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");
int [] array = FillArray(size, minimum, maximum);
PrintArray(array);
ReArray(array);
PrintArray(array);