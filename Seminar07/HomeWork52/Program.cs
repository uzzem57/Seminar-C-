// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
double[] result = new double[array.GetLength(1)];
int sum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int J = 0; J < array.GetLength(0); J++)
    {
        sum = sum + array[J, i];
    }
    result[i] = Convert.ToDouble(sum) / array.GetLength(0);
    sum = 0;
}

Console.WriteLine(string.Join("; ", result));
