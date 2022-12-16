// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 
// Например, задан массив:
 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
int [,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
int count = 0;
int [] arraysum = new int [array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count = count + array[i,j];
    }
    arraysum[i] = count;
    count =0;
}
 
int indexminsize =0;
int min = arraysum[0];
for (int i=0; i <arraysum.Length; i++){
    if (min>arraysum[i]){
        min = arraysum[i];
        indexminsize = i;
    }
 
}
int printresult = indexminsize +1;// Для нормального отображения под пользователя.
System.Console.WriteLine("Строка с наименьшей суммой элементов - " + printresult );