using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var N = Convert.ToInt32(Console.ReadLine());
        
        FillPhoneBook(N, out IDictionary<string, string> phoneBook);
        
        SearchForPhoneNumberByName(phoneBook);
    }
    
    private static void FillPhoneBook(int N, out IDictionary<string, string> phoneBook){        
        phoneBook = new Dictionary<string, string>();
        for (int i = 0; i < N; i++){
            var nameNumber = Console.ReadLine().Split(' ');
            phoneBook.Add(nameNumber[0], nameNumber[1]);            
        }        
    }
	
	private static void SearchForPhoneNumberByName(IDictionary<string, string> phoneBook)   {
		string name;
        while((name = Console.ReadLine()) != null){
           if(phoneBook.TryGetValue(name, out string value)){
               Console.WriteLine(String.Format("{0}={1}",name, value));
           } else{
               Console.WriteLine("Not found");
           }
        }
	}
}