// On the morning of the wedding, the groom should not see the bride. If he does, this is bad luck.

//Возвращает количество (количество) гласных в заданной строке.

//Мы будем рассматривать a, e, i, o, uкак гласные для этой Ката (но не y).

int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for ( int i=0; i<str.Length;i++){
            if ( str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o'){
                vowelCount ++;
            }
        }
        return vowelCount;
    }
    string text ="abracadabra";
    Console.Write(GetVowelCount(text));


