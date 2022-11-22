Console.WriteLine("Введите число");
int data = Convert.ToInt32(Console.ReadLine());
if(data<2){
   Console.Write ("Нет положительных четных чисел"); 
}
else {
    for (int i = 2; i<=data; i+=2) {
    Console.Write (i + " ");
     }
}