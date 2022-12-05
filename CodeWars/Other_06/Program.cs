int MakeNegative(int number)
  {
     return number > 0 ? -number : number;
  //return -Math.Abs(number);
  }

  Console.WriteLine(MakeNegative(9));