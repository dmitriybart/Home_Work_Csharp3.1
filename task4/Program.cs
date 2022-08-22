// Определить, присутствует ли в заданном массиве, некоторое число
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

int IndexOf(int[]array, int find)
{
int position = -1; 
for(int i = 0; i < array.Length; i++)
{
if(array[i] == find)
{
position = i;
break;
}
}
return position;
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");

int [] array = FillArray(size, minimum, maximum);

PrintArray(array);

Console.Write("Введите число которое мы должны найти в массиве: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int NumberArray = IndexOf(array, number);

if (NumberArray > -1)
{
    Console.WriteLine($"Число {number} находится в ячейке под номером {NumberArray + 1}, с индексом {NumberArray}");
}
else 
Console.WriteLine($"Число {number} не находится в заданном массиве !");