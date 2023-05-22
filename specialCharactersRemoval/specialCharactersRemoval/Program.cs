using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace specialCharactersRemoval
{   /*Write a C# Sharp program to remove the special characters from a given text.
    Return the new string which allowed alphanumeric characters, spaces, underscores _ and dashes - .*/
    internal class Program
    {                                       
        static void Main(string[] args)
        {
            String[] special = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "]", "\"", "/", ",", "'", ":", ";", ".", "|", "{", "}"};
            Console.Write("Enter text: ");
            String text = Console.ReadLine();
            
            for(int i=0;i<special.Length; i++)
            {
                if (text.Contains(special[i]))
                {
                    text = text.Replace(special[i],"");
                }
            }
            Console.WriteLine(text);
            
            /*string replacedText = Regex.Replace(text, "[^0-9A-Za-z _-]", "");
            Console.WriteLine(replacedText);*/

        }
    }
}

// m@Y_ N-ame is#$%^&**) (arun420