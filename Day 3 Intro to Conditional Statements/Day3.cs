using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    private static void Checkinput(int input){
        var isOdd = input % 2 != 0;
        if(isOdd){
            Console.WriteLine("Weird");
        } else if(input >= 2 && input <= 5){
            Console.WriteLine("Not Weird");            
        } else if(input >= 6 && input <= 20){
            Console.WriteLine("Weird");            
        } else{
            Console.WriteLine("Not Weird");                        
        }
    }

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        Checkinput(N);
    }
}