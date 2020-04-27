using System.Collections.Generic;
using System;


namespace piglatin
{
    class Program
    {
        public static void Main(string[] args )
        {
            Console.WriteLine("which word would you like to use to change to latin");

            char [] vowels = {'a','e','i','o', 'u' };
            List<string> pigWords = new List<string>();

            string sentence = Console.ReadLine(
                ).ToLower();
            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string lastletter = word.Substring(word.Length -1);
                string restOfWord = word[1..];
                int currentLetter = word.IndexOfAny(vowels);

                if (currentLetter == -1)
                {
                    pigWords.Add(word + "ay");
                }
                else if (firstLetter.IndexOfAny(vowels) == 0)
                {
                    if (lastletter.IndexOfAny(vowels) == 0)
                    {
                        pigWords.Add(word +"yay");
                    }
                    else
                    {
                        pigWords.Add(word + "ay");
                    }
                }
                else
                {
                    pigWords.Add(restOfWord + firstLetter +"ay");
                }
            }
             string.Join(" ", pigWords);
            foreach (string word in pigWords)
                Console.WriteLine(word);
        }
    }
}
