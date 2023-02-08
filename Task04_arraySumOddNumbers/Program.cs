// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
int sum=0;
PrintArray (array);
for (int i = 1; i<array.Length; i=i+2)
sum=sum+array[i];
Console.WriteLine($"Сумма элементов массива, стоящих на нечетной позиции, равна {sum}");