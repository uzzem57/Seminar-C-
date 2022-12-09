int CountSheeps(bool[] sheeps)
  {
    int count = 0;
    for (int i =0; i < sheeps.Length;i++){
      if (sheeps[i] ==true){
        count ++;
      }
    }
    return count;
  }
  bool [] x = {true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true};
Console.WriteLine(CountSheeps(x));