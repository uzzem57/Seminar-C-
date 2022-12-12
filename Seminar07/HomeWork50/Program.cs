// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4, }, };
Console.WriteLine("Введите число позиции по горизонтали");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число позиции по вертикали");
int column = Convert.ToInt32(Console.ReadLine());
if (rows > matrix.GetLength(0) || column > matrix.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else if ((rows <0 || column < 0))
{
    Console.WriteLine("Вы ввели отрицатльное значение");
}
else
{
    Console.WriteLine("Значение элемента указанной позиции - " + matrix[rows, column]);
}