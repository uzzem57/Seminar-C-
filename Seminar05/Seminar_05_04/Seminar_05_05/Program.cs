// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int [] array = {1, 2, 3, 4, 5, 6, 7};
int []data = new int[array.Length/2 + array.Length%2];
for(int i=0; i<array.Length/2;i++){
    data[i] = array[i]*array[array.Length-i-1];
     
}
if (array.Length%2 !=0){
    data[data.Length-1]= array[array.Length/2];
}
Console.WriteLine(string.Join(", ", data));