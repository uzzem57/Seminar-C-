// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
const int SIZE = 8;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100;

int [] newArray = GetRandomArray(SIZE,LEFTRANGE,RIGHTRANGE);
int maxdata = newArray[0];
int mindata = newArray[0];
for (int i = 0; i < newArray.Length; i++)
{
    if (maxdata < newArray[i]){
        maxdata = newArray[i];
    }       
}
for (int i = 0; i < newArray.Length; i++)
{
    if (mindata > newArray[i]){
        mindata = newArray[i];
    }       
}
int result = maxdata - mindata;

Console.WriteLine(result);
