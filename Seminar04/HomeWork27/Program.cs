﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите число");
int data = Convert.ToInt32(Console.ReadLine());
int sum =0;
if ( data < 0) {
    Console.WriteLine("Вы ввели отрицательное число");
}
else {
    while(data > 0){
        sum = sum + data % 10;
        data = data /10;
    }
    Console.WriteLine("Сумма цифр в числе = " + sum);
}
