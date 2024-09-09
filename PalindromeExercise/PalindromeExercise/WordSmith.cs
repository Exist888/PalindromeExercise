using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeExercise;


//Note to self, source: https://www.designgurus.io/answers/detail/how-to-reverse-a-string-in-c
public class WordSmith
{
    public bool IsAPalindrome(string input)
    {
        if (input == null)
        {
            return false;
        }

        char[] inputAsCharArray = input.ToCharArray();          //create new char array, convert string input to char array
        // char[] inputAsCharArray = new char[] { };
        // inputAsCharArray = input.ToCharArray();
        Array.Reverse(inputAsCharArray);                        //Array Class, Reverse Method to char array, argument inputAsCharArray
        string reversedString = new string(inputAsCharArray);   //declare new string from reversed char array

        if (input.ToLower() == reversedString.ToLower())        //If statement, if original input and reversed input are equal, input is a palindrome
        {                                                       //Use ToLower for original and reversed to account for capitalization
            return true;
        }
        else
        {
            return false;
        }
        
        // List<char> stringAsListForward = new List<char>{};
        // List<char> stringAsListBackward = new List<char>{};
        //
        // var inputOriginal = input.ToList();
        // stringAsListForward.Add(inputOriginal);
    }
}