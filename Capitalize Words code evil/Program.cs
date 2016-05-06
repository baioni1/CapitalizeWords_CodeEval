using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_Words_code_evil
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a string variable for code eval to read named line
            string line = "1st thing";
            //line to an array and split the words/seperate them to find the first letter in each word
            string[] words = line.Split();
            // I need a loop to look for the first letter in each word in the array
            foreach(string word in words)
            {
                char firstChar = word[0];//use char to find the 1 place in the word
                firstChar = char.ToUpper(firstChar);//change the char to uppercase letter
                Console.Write(firstChar + word.Substring(1,word.Length-1)+" ");//writes out the first letter in upper case
                //+ the word starting at the second letter all the way through the length of the word
                //to the end and add space between the words
                //-1 taking into consideration of the first char made to uppercase
            }
            Console.WriteLine();    


        }
    }
}
