int [] array = new int [7];
Random rdn = new Random();
for (int i=0; i< array.Length; i++){
  array[i] = rdn.Next(1,10);
     for (int j = 0; j<i; j++){
      if(array[i] == array[j]){
        array[i] = rdn.Next(1,10);
      }
     }
}
Console.WriteLine(string.Join(" ", array));