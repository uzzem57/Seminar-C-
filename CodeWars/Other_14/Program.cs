// * "String"      -> "SSttrriinngg"
// * "Hello World" -> "HHeelllloo  WWoorrlldd"
// * "1234!_ "     -> "11223344!!__  "

string data = "1234!_ ";
string newdata = string.Empty;
for( int i=0; i<data.Length;i++){
    newdata = newdata + data[i] + data[i];
} 
Console.WriteLine(newdata);