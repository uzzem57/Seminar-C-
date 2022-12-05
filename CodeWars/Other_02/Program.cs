string text = " Определение проектов для восстановления";

string replacetext(string arg, char oldsymbol, char newsymbol){
    string result = string.Empty;
    for( int i =0; i < arg.Length; i++){
        if( arg[i] == oldsymbol){
           result  = result + newsymbol; 
        }
        else {
           result  = result + arg[i];
        }
    }
    
    return result;
}

string newtext = replacetext(text, 'е', 'И');
Console.WriteLine(newtext);
