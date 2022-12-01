// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

//Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите число А");
int dataA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int count = dataA;
int dataB = Convert.ToInt32(Console.ReadLine());
for ( int i =1 ; i <dataB; i++){
    count = count*dataA;
}
Console.WriteLine(" А в степени В равно " + count);

