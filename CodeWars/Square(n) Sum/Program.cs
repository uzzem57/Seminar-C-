
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    for ( int i =0; i < numbers.Length; i++) {
        numbers[i] = numbers[i] * numbers[i];
    }
    int count =0;
    for (int i =0; i < numbers.Length; i++) {
        count = count + numbers [i];
    }
    return count;
    
  }

}
