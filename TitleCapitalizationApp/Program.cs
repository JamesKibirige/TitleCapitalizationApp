using System;
using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationApp
{
    public class Program
    {
        public static string LowerCaseWord(string word)
        {
            return word.ToLower();
        }
        public static string CapitalizeWord(string word)
        {
            //1. Make all letters in word Lower Case
            StringBuilder sb = new StringBuilder(LowerCaseWord(word));

            //2. Capitalize first letter in word
            char firstLetter = Char.ToUpper(sb[0]);
            sb[0] = firstLetter;

            return sb.ToString();
        }

        public static string CapitalizeTitle(string title)
        {
            //0.    Variable that will hold resulting capitalized Title
            string capitalizedTitle;

            //1.    Check for special cases where entered title is NULL, White space or Empty String
            if (String.IsNullOrWhiteSpace(title))
            {
                capitalizedTitle = title;
                return capitalizedTitle;
            }
     
            //1. First step make all characters lowercase in title parameter
            title = LowerCaseWord(title);

            //2. Split string into an array of Strings using a space ' ' as a seperator to delimit the strings
            char[] seperator = new char[] {' '};
            var titleWords = title.Split(seperator);

            //3. Populate a List of lowerCaseWords that define the set of words that should be lowercased in a Title
            List<string> lowerCaseWords = new List<string>()
            {
               "a",
               "the",
               "to",
               "at",
               "in",
               "with",
               "and",
               "but",
               "or"
            };

            lowerCaseWords.Sort();//Sort list into alphabetical order to optimise any item searches that may be performed in future

            //4.    Loop over collection of words in the array titleWords capitalizing the correct words according to the Capitalization rules
            for (int i = 0; i < titleWords.Length; i++)
            {
                //a.    Capitalize words if they are the first word in the tile (i==0)
                if (i == 0 || i == titleWords.Length || (!lowerCaseWords.Contains(titleWords[i])))
                {
                    titleWords[i] = CapitalizeWord(titleWords[i]);
                }
            }

            //5.
            capitalizedTitle = String.Join(' ',titleWords);

            return capitalizedTitle;
        }

        public static void Main(string[] args)
        {
            //Example 1: "i love solving problems and it is fun"
            string firstExample = CapitalizeTitle("i love solving problems and it is fun");

            //Example 2: "wHy DoeS A biRd Fly?"
            string secondExample = CapitalizeTitle("wHy Does A bIrd Fly?");

            //Example 3: " "
            string thirdExample = CapitalizeTitle(" ");

            //Example 4: ""
            string fourthExample = CapitalizeTitle("");

            Console.WriteLine("Example 1 -'i love solving problems and it is fun': " + firstExample);
            Console.WriteLine("Example 2 -'wHy DoeS A biRd Fly?': " + secondExample);
            Console.WriteLine("Example 3 -' ': " + thirdExample);
            Console.WriteLine("Example 4 -'': " + fourthExample);
        }
    }
}
