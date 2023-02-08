// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] CreateArray (int length, int from, int to)
{
    int [] array  = new int [length];
    for (int i=0; i<length; i++)
    array[i]=new Random().Next(from,to+1);
    return array;
}

void PrintArray(int [] array)
{
    Console.WriteLine();
    foreach (int element in array)
    Console.Write(element+"\t");
    Console.WriteLine();
    Console.WriteLine();
}

int ReadInt (string OutputMes)
{
Console.WriteLine(OutputMes);
int inputNumber = int.Parse(Console.ReadLine()!);
return inputNumber;
}

int length = ReadInt("Введите длину массива: ");
int rangeFrom= ReadInt("Введите начало диапазона чисел: ");
int rangeTo = ReadInt("Введите конец диапазона чисел: ");
int [] array = CreateArray(length, rangeFrom, rangeTo);
int max=array[0];
int min=array[0];
PrintArray (array);
for (int i=1; i<array.Length; i++)
{
    if (array[i]>max)
    max=array[i];
    else if (array[i]<min)
    min=array[i];
}
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max-min}");