string Correct(string text)
  {
    return text
    .Replace("0", "O")
    .Replace("1", "I")
    .Replace("5", "S");
  }

Console.WriteLine(Correct("5EM1NAR"));