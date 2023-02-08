// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] CreateArray (int Length, int from, int to)
{
    int [] array  = new int [Length];
    for (int i=0; i<array.Length; i++)
    array[i]=new Random().Next(from,to+1);
    return array;
}

void PrintArray(int [] array)
{
    Console.WriteLine();
    foreach (int element in array)
    Console.Write(element+"\t");
    Console.WriteLine();
}

int ReadInt (string OutputMes)
{
Console.WriteLine(OutputMes);
int inputNumber = int.Parse(Console.ReadLine()!);
return inputNumber;
}

int length = 123;
int rangeFrom= ReadInt("Введите начало диапазона чисел: ");
int rangeTo = ReadInt("Введите конец диапазона чисел: ");
int [] array = CreateArray(length, rangeFrom, rangeTo);
int count=0;
PrintArray(array);
Console.WriteLine ("Элементы из отрезка [10,99] в массиве:");

for (int i=0; i<array.Length; i++)
if (array[i]>=10 && array [i]<=99)
{
    count++;
    Console.Write(array[i]+"\t");
}
Console.WriteLine();    
Console.WriteLine($"Количество элементов из отрезка [10,99] в массиве - {count}");


