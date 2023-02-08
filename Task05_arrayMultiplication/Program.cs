// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
PrintArray (array);
for (int i = 0; i < array.Length/2; i++)
Console.WriteLine($"Произведение {i} элемента массива и {array.Length-1-i} элемента массива равно {array[i]*array[array.Length-1-i]}");
if (array.Length%2!=0)
Console.WriteLine ($"А для {array.Length/2+1} элемента пары нет :(");