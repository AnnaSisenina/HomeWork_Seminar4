// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] CreateArray (int length, int from, int to)
{
    int [] array  = new int [length];
    for (int i=0; i<length; i++)
    array[i]=new Random().Next(from,to+1);
    return array;
}

void PrintArray(int [] array)
{
    foreach (int element in array)
    Console.Write(element+"\t");
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона чисел: ");
int rangeFrom= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона чисел: ");
int rangeTo = int.Parse(Console.ReadLine()!);
int [] array = CreateArray(length, rangeFrom, rangeTo);
PrintArray(array);

