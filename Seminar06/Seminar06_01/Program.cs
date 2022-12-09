//  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > (b+c)){
    Console.WriteLine("Треугольник с такими сторонами существовать не может");
}
else if (b > (a+c)){
    Console.WriteLine("Треугольник с такими сторонами существовать не может");
}
else if (c > (a+b)){
    Console.WriteLine("Треугольник с такими сторонами существовать не может");
}
else {
    Console.WriteLine("Треугольник с такими сторонами существовать  может");
}
