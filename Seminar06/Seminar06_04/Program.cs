// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] CopyMas (int [] array){
    int [] newmas = new int [array.Length];
    for (int i=0; i<array.Length;i++){
        newmas[i] = array[i];
    }
    return newmas;
}

int [] mas ={7,2,3,4,5,6,7};
int [] newmas = CopyMas(mas);
Console.WriteLine(string.Join(" ", newmas));