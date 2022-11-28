//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x точки A"); 
int x = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y точки A"); 
int y = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z точки A"); 
int z = Convert.ToInt32(Console.ReadLine()); 
  
Console.WriteLine("Введите координату x2 точки B"); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y2 точки B"); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z2 точки B"); 
int z2 = Convert.ToInt32(Console.ReadLine()); 
 
double sum = Math.Sqrt((x2 - x) * (x2 -x ) + (y2 - y) * (y2 - y) + (z2 - z) * (z2 - z )); 
 
Console.WriteLine($"{sum:f2}"); // два знака после запятой