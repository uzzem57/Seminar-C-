Console.Write("Введите первое число: ");
int finish_data = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int data = Convert.ToInt32(Console.ReadLine());
if (finish_data == data*data) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}