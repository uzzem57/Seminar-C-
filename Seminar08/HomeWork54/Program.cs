// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
for (int i = 0; i < array.GetLength(0); i++)
{
    int min = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 1; k < array.GetLength(1); k++)
        {
            if (min > array[i, k])
            {
                int temp = array[i, k];
                array[i, k] = array[i, k - 1];
                array[i, k - 1] = temp;
            }
            else
            {
                min = array[i, k];
            }
        }
        min = array[i, 0];
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]+ " ");
    }
    System.Console.WriteLine();
}
