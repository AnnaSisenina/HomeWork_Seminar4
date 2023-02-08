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

int length = 8;
int rangeFrom= 0;
int rangeTo = 1;
int [] array = CreateArray(length, rangeFrom, rangeTo);

Console.WriteLine ("Массив из 8 элементов, заполненный 0 и 1:");
PrintArray(array);
