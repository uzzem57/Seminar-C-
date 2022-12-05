//Вам даны length и width четырехугольника. Многоугольник может быть прямоугольным или квадратным.
//Если это квадрат, вернуть его площадь. Если это прямоугольник, верните его периметр.

//Пример (Ввод1, Ввод2 --> Выход):

 int AreaOrPerimeter(int l, int w) {
     return l == w ? l*w : (l+w)*2;
     }

 int result = AreaOrPerimeter(3,5);
 Console.WriteLine(result);
    

