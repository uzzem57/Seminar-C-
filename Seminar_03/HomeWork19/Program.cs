//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int data = Convert.ToInt32(Console.ReadLine());
int data5 = data % 10;
int data4 = (data/10) % 10;
int data2 = (data/1000) % 10;
int data1 = (data/10000);
if ( data < 10000 || data > 99999) {
    Console.WriteLine("Вы ввели не пятизначное число");
    }
else {
    if ( data1 == data5 && data2 == data4) {
        Console.WriteLine("Данное число является палиндромом");
    }
    else {
       Console.WriteLine("Данное число НЕ является палиндромом"); 
    }
}

    

