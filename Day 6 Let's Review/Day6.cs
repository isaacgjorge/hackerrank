using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       var t = int.Parse(Console.ReadLine());
       
       for(int i =0; i < t ; i++){
           var testWord = Console.ReadLine();
           SplitWord(testWord);
       }       
    }
    
    private static void SplitWord(string testWord){
        var odd = "";
        var even = "";
        
        for(int i = 0; i < testWord.Length; i++ ){
            if(i%2 == 0){
                even += testWord[i];
            } else {
                odd += testWord[i];
            }
        }
        Console.WriteLine(even + " " + odd);
    }
}