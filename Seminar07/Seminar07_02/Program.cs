// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int [,] matr = new int [3,4];
 for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matr[i, j] = i+j;
        }
    }
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }