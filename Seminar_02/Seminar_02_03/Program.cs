Console.WriteLine("Введите число");
int data1 = Convert.ToInt32(Console.ReadLine());
int data2 = 7;
int data3 = 23;
if (data1 % data2 == 0 || data1 % data3 == 0) {
    Console.WriteLine("Кратно");
}
else{
     Console.WriteLine("Некратно");
}

