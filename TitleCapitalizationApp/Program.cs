using System;
using System.Collections.Generic;
using System.Text;

namespace TitleCapitalizationApp
{
    class Program
    {
        public static string CapitalizeWord(string word)
        {
            //1. Make all letters in word Lower Case
            StringBuilder sb = new StringBuilder(word.ToLower());

            //2. Capitalize first letter in word
            char firstLetter = Char.ToUpper(sb[0]);
            sb[0] = firstLetter;

            return sb.ToString();
        }

        public static string CapitalizeTitle(string title)
        {
            //0. First step make all characters lowercase in title parameter
            title = title.ToLower();

            //1. Split string into an array of Strings using a space ' ' as a seperator to delimit the strings
            char[] seperator = new char[] {' '};
            var titleWords = title.Split(seperator);

            //2. Get First and Last words in Title and Capitalize them
            string firstWord = CapitalizeWord(titleWords[0]);
            titleWords[0] = firstWord;
            string lastWord = CapitalizeWord(titleWords[titleWords.Length - 1]);
            titleWords[titleWords.Length - 1] = lastWord;

            //3. Process strings from mid-section of title applying Capitalization rules
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
            lowerCaseWords.Sort();

            //4.
            for (int i = 1; i < titleWords.Length - 1; i++)
            {
                var x = titleWords[i];
                if (lowerCaseWords.Contains(x))
                {
                    x = titleWords[i].ToLower();
                    titleWords[i] = x;
                }
                else
                {
                    x = CapitalizeWord(titleWords[i]);
                    titleWords[i] = x;
                }
            }

            //5.
            string capitalizedTitle = String.Empty;
            foreach (var word in titleWords)
            {
                if (capitalizedTitle == String.Empty)
                {
                    capitalizedTitle = capitalizedTitle + word;
                }
                else
                {
                    capitalizedTitle = capitalizedTitle + " " + word;
                }
            }

            return capitalizedTitle;
        }

        public static void Main(string[] args)
        {
            //Example 1: "i love solving problems and it is fun"
            string firstExample = CapitalizeTitle("i love solving problems and it is fun");

            //Example 2: "wHy DoeS A biRd Fly?"
            string secondExample = CapitalizeTitle("wHy Does A bIrd Fly?");

            Console.WriteLine("Example 1 -'i love solving problems and it is fun': " + firstExample);
            Console.WriteLine("Example 2 -'wHy DoeS A biRd Fly?': " + secondExample);
        }
    }
}
