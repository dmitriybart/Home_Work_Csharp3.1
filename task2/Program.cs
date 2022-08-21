// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
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
int size = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine());
int [] array = FillArray(size, minimum, maximum);
PrintArray(array);
int i=0;
int sum=0;
int sum2=0;
while (i < size)
{
    if (array[i]>=0)
    {
        sum2=sum2+array[i];
        i++;
    }
    else 
    {
        sum=sum+array[i];
        i++;
    }
}
Console.WriteLine("Сумма отрицательных чисел равна: " +sum);
Console.WriteLine("Сумма положительных чисел равна: " +sum2);