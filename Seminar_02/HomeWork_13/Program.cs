//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 
Console.WriteLine("Введите число");
long data = Convert.ToInt64(Console.ReadLine());
 
if ( data < 100){
    Console.WriteLine("Третьей цифры нет");
    }
else if ( data > 99 && data < 1000 ) {
    Console.WriteLine(data % 10 );
    }   
else if ( data > 999 && data < 10000 ) {
    long data_cor = data / 10;
    Console.WriteLine(data_cor % 10);
    } 
else if ( data > 9999 && data < 100000 ) {
    long data_cor = data / 100;
    Console.WriteLine(data_cor % 10);
    } 
else if ( data > 99999 && data < 1000000 ) {
    long data_cor = data / 1000;
    Console.WriteLine(data_cor % 10);
    } 
else if ( data > 999999 && data < 10000000 ) {
    long data_cor = data / 10000;
    Console.WriteLine(data_cor % 10);
    } 
else if ( data > 9999999 && data < 100000000 ) {
    long data_cor = data / 100000;
    Console.WriteLine(data_cor % 10);
    } 
else if ( data > 99999999 && data < 1000000000 ) {
    long data_cor = data / 1000000;
    Console.WriteLine(data_cor % 10);
    }
else {
    Console.WriteLine("Вы ввели число выходящее за рамки поставленного ТЗ на данную задачу");
}    
  