Console.WriteLine("Введите первое число");
int data_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int data_2 = Convert.ToInt32(Console.ReadLine());
if (data_1>data_2) {
Console.WriteLine("max = " + data_1 + ", " + "min = " + data_2);
}
else {
Console.WriteLine("max = " + data_2 + ", " + "min = " + data_1);
}

