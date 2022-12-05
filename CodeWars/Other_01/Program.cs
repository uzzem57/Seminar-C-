int [] arr = {1,5,3,9,2};
int reverse (int [] arg){
 int sum =0;
int maxdata = arr[0];
    for( int j=arr.Length; j >0; j--){
        for( int i =1; i < arr.Length; i++){
            if (maxdata > arr[i]){
            int temp = arr[i];
            arr [i] = arr [i-1];
            arr [i-1] = temp;
            }
            else {
            maxdata = arr[i];
            }
        }   
        maxdata = arr[0];
    }
    for (int i = 1; i < (arr.Length - 1); i++){
         sum = sum + arr [i];
    }
    return sum;
}
// void printreverse(int [] massiv) {
// for (int i=0; i<arr.Length; i++){
//     Console.Write( arr[i] + " ");
// }
// }
int result = reverse(arr);
Console.WriteLine(result);
// printreverse(arr);











