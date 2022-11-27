
int [] arraw = {23,45,1,3,77,21,56,78};
int count = 0;
for (int i = 0; i < arraw.Length; i++) {
    if (arraw [i] == 78) {
        Console.WriteLine ( count );
        break;
            }
    else {
        count ++;
    }
}
if (count >= arraw.Length) 
 Console.WriteLine("Данного числа нет в массиве");
   