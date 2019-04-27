using System;
using System.IO;
class MainClass{
public void MorseEncoder(){
    bool cont = true;
    string morse;
    int i= 0;
    string [] morseAlphabet = new string[26] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    string [] alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    while(cont){
    Console.WriteLine("0 - Show Alphabet & Morse List\n1 - Morse Code to Aplhabet\n2 - Alphabet to Morse Code\n3 - Quit");
    int choice = int.Parse(Console.ReadLine());
    if(choice==1){
        Console.Write("Morse Code : ");
        morse = Console.ReadLine();
        string[] parts = morse.Split(' ');
            for(int l=0;l<parts.Length;l++){
                for(int k=0;k<26;k++){
                if(parts[l]==morseAlphabet[k]){
                Console.Write(alphabet[k]);
                }
                }
            }
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
        }
    else if(choice==2){
    string alphabetx = "abcdefghijklmnopqrstuvwxyz";
    string alphabety = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     char[] charArrx = alphabetx.ToCharArray();
     char[] charArry = alphabety.ToCharArray();
        Console.Write("Alphabet : ");
        string alphabetInput = Console.ReadLine();
         char[] parts2 = alphabetInput.ToCharArray();
            for(int l=0;l<parts2.Length;l++){
                for(int k=0;k<26;k++){
                if((parts2[l]==charArrx[k])||(parts2[l]==charArry[k])){
                Console.Write(morseAlphabet[k]+" ");
                }
                }
            }
             Console.WriteLine();
             Console.ReadLine();
             Console.Clear();
    }
    else if(choice==3){
        cont = false;
        Environment.Exit(1);
    }
    else if(choice==0){
        Console.WriteLine("########### Morse Code Alphabet ##########");
        while(i<26){
            Console.WriteLine("morse code : {0}\t\t\t\talphabet : {1}",morseAlphabet[i],alphabet[i]);
            i++;
        }

    }
    else{
        Console.WriteLine("Invalid Input, try again");
        choice = int.Parse(Console.ReadLine());
        Console.Clear();
    }
   }
   Console.Clear();
}

public static void Main(string[] args)
	{
        MainClass ob = new MainClass();
		ob.MorseEncoder();
    }
}