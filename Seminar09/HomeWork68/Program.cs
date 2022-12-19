// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
//https://math.fandom.com/ru/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

 int FunctionAccerman(int m, int n )
 {
    if (m == 0){
        return n + 1;
    }

    else if ( n == 0 && m > 0) {
        return FunctionAccerman (m - 1, 1);
        
    }

    else 
      return FunctionAccerman (m-1, FunctionAccerman(m, n -1));
    
 }

 int resultAccerman = FunctionAccerman(m,n); 
Console.WriteLine(resultAccerman);