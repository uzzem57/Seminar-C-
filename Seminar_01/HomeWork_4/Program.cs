
int [] data = new int [3];
Console.WriteLine("Введите первое число");
data [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
data [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
data [2]= Convert.ToInt32(Console.ReadLine());
int count =0;
int max=0;
while (count <3 ) {
       if ( max < data[count]){
           max = data[count];
           count ++;
           }
        else {
            count ++;
        }
}
Console.WriteLine("Максимальное число = " + max);