// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray(int[] array)
{
    int index = 0;
    var random = new Random();
    while (index < array.Length)
    {
        array[index] = random.Next(0, 2);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int position = 0;
    while (position < collection.Length)
{
    Console.Write(collection[position] +" ");
    position++;
}
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);