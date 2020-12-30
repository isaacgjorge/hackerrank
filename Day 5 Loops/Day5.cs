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
    
    private static void calc(int number){
        
        for(int i = 1; i <=10; i++){
            var result = number * i;
            Console.WriteLine(number + " x " + i + " = " + result);
        }
    }


    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        calc(n);
    }
}