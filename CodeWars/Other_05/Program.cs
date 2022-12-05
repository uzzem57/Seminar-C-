
//Это ката об умножении заданного числа на восемь, если оно четное, и на девять в противном случае.

int Multiply(int x){
    if ( x % 2 ==0){
        return x*8;
    }
    else {
        return x*9;
    }
}

Console.WriteLine(Multiply(4));

int e = 345;
Console.WriteLine(e.ToString());