//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 
Console.WriteLine("Введите число");
long data = Convert.ToInt64(Console.ReadLine());
    if (data < 100) {
    Console.WriteLine("Третьей цифры нет");
    }
    else {
        while( data > 999) {
            data = data/10;
        }
        Console.WriteLine(data % 10);
    }
 
