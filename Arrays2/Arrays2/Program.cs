using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that will print out your first name and last name, 
            //with correct punctuation (e.g. upper case characters where needed, like the first letter of each name).
            //To get the characters, create two arrays, the first one with all of the lower-case characters
            //in the alphabet.  The second array will have all of the upper case letters in the alphabet.  
            //If you have special characters in your name that are outside of the standard english alphabet,
            //you can disregard this or you can add them to your arrays as well. 
            //Using your two arrays, access the correct elements to concatenate your name and output it to the
            //console window. 

            char[] lowercaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string firstName, lastName;
            int i;

            firstName = string.Concat(uppercaseLetters[3], lowercaseLetters[0], lowercaseLetters[21], lowercaseLetters[8], lowercaseLetters[3]);
            lastName = string.Concat(uppercaseLetters[0], lowercaseLetters[11], lowercaseLetters[11], lowercaseLetters[8], lowercaseLetters[18], lowercaseLetters[14], lowercaseLetters[13]);

            Console.WriteLine($"{firstName} {lastName}");
            Console.ReadKey();
        }
    }
}
