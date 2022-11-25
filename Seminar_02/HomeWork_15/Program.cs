//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7 включительно");
int data = Convert.ToInt32(Console.ReadLine());
if (data < 1 || data > 7) {
    Console.WriteLine("Вы ввели не корректное число");
    }
else if ( data == 6 || data == 7) {
    Console.WriteLine("Да");
    }
else {
    Console.WriteLine("Нет");
}