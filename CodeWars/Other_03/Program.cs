

// int Sum(int[] arr){
// int sum =0;
// int maxdata = arr[0];
//     for( int j=arr.Length; j >0; j--){
//         for( int i =1; i < arr.Length; i++){
//             if (maxdata > arr[i]){
//             int temp = arr[i];
//             arr [i] = arr [i-1];
//             arr [i-1] = temp;
//             }
//             else {
//             maxdata = arr[i];
//             }
//         }   
//         maxdata = arr[0];
//     }
//     for (int i = 1; i < (arr.Length - 1); i++){
//          sum = sum + arr [i];
//     }
//     return sum;
// }
// int[] mass = {2,8,1,9};
// int x =Sum(mass);
// Console.WriteLine(x);

using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
     int sum =0;
     int maxdata = numbers[0];
        for( int j=numbers.Length; j >0; j--){
            for( int i =1; i < numbers.Length; i++){
                if (maxdata > numbers[i]){
                int temp = numbers[i];
                numbers [i] = numbers [i-1];
                numbers [i-1] = temp;
                }
             else {
                maxdata = numbers[i];
                }
        }   
        maxdata = numbers[0];
    }
    for (int i = 1; i < (numbers.Length - 1); i++){
         sum = sum + numbers [i];
    }
    return sum;
   }
}

