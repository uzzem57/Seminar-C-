// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
const int SIZE = 14;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int [] newArray = GetRandomArray(SIZE,LEFTRANGE,RIGHTRANGE);
int count = 0;
for (int i = 0; i < newArray.Length;i++){
    if (newArray[i]%2 == 0){
        count++;
    }
}
Console.WriteLine("Количество четных значений в массиве - " + count);