// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

 void numbers(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write(sum);
         return;
     }
     numbers(m, n - 1, sum);
 }
 //проверка: если первое введенное число больше второго, меняем значения местами
 int temp = m;
 if (m > n)
 {
     m = n;
     n = temp;
 }

 numbers(m, n, 0);