//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
//456 -> 5
//782 -> 8
//918 -> 1
 
Console.WriteLine("Введите трехзначное число");
int data = Convert.ToInt32(Console.ReadLine());
     if ( data < 100 || data > 999){
         Console.WriteLine("Вы ввели не трехзначное число");
        }
     else {
        int data_cor = data/10;
        Console.WriteLine($"Вторая цифра в введенном числе - {data_cor % 10}");
          }