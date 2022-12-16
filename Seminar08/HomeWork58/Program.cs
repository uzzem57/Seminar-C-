// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


 
//В ТЗ нет , но можно еще сделать проверку на соответствие двух массивов, в if (если количество строк и столбцов не равны у соответствующих массивов
// то выкидывать сообщение пользователю и на break) , а в esle то что ниже
 
int [,] arrayfirst = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
int [,] arraysecond = {{1, 5, 8, 5}, {4, 9, 4, 2}, {7, 2, 2, 6}, {2, 3, 4, 7}};
int [,] arrayresult = new int [ arrayfirst.GetLength(0), arrayfirst.GetLength(1)];
for (int i = 0; i< arrayfirst.GetLength(0); i++){
    for (int j=0; j<arrayfirst.GetLength(1); j++){
        arrayresult [i,j] = arrayfirst[i,j] * arraysecond[i,j];
    }
}
 
for (int i = 0; i< arrayresult.GetLength(0); i++){
    for (int j=0; j<arrayresult.GetLength(1); j++){
        Console.Write(arrayresult[i,j] + " ");
    }
    Console.WriteLine(" ");
}  