using System;
using System.Collection.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace manymethods

{
    public class Program
    {
        static void hello(string[] args)
        {
            string firstname = "pj";
            string lastname = "orme";

            Console.WriteLine("name " + firstname + " " + lastname);
            Console.WriteLine("please enter a new name");
            firstname = Console.ReadLine();
            Console.WriteLine("new name: " + firstname + "" + lastname);
            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }


        public class additio
        {
            public static int Sum(int num1, int num2)
            {
                int total;
                total = num1 + num2;
                return total;
            }

            public static void Main()
            {
                Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
                Console.Write("--------------------------------------------------\n");
                Console.Write("Enter a number: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
            }
        }

    }

    public class catDog
    {
        public static void Main()
        {



            cat_dog("catdog");
            cat_dog("catcat");
            cat_dog("1cat1cadodog"); }



        static void cat_dog(string input)
        {
            int cats = 0, dogs = 0;

            for (int i = 0; i < input.Length - 2; i++)
            {

                if (input.Substring(i, 3) == "cat")
                {
                    cats++;
                    i = i + 2;
                }
                else if (input.Substring(i, 3) == "dog")
                {
                    dogs++;
                    i = i + 2;
                }

            }

            if (cats == dogs)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine(" ");

        }
    }
        public class oddEvent
        {
        public static void Main()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        }
    };

        public class inches
        {
        static void inches()
        {
            var result = ToFeetInches(70.0);
            Console.WriteLine(result);

            result = ToFeetInches(61.5);
            Console.WriteLine(result);

            result = ToFeetInches(72.0);
            Console.WriteLine(result);
        }

        static KeyValuePair<int, double> ToFeetInches(double inches)
        {
            return new KeyValuePair<int, double>((int)inches / 12, inches % 12);
        }
    }

        public class echo
        {
        void convertOpposite(string str)
        {
            int ln = str.length();

         
            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                
                    str[i] = str[i] - 32;
                else if (str[i] >= 'A' && str[i] <= 'Z')
                  
                    str[i] = str[i] + 32;
            }
        }

        
        int main()
        {
            string str = "GeEkSfOrGeEkS";

           
            convertOpposite(str);

            cout << str;
            return 0;
        }
    }

        public class killGrams
        {
        public static void Main()
        {
            Console.WriteLine("Enter the value in kilograms: ");
            double valueInKg = Convert.ToDouble(Console.ReadLine());

            var valueInPound = HelperClass.KilogramToPounds(valueInKg);
            Console.WriteLine("Value in pounds is {0}", valueInPound);
        }
    }
}

public class date
{
    public static void Main()
    {
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            Console.WriteLine("{0}:", culture.NativeName);
            Console.WriteLine("   Local date and time: {0}, {1:G}",
                              localDate.ToString(culture), localDate.Kind);
            Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                              utcDate.ToString(culture), utcDate.Kind);
        }
    }
}
        

public class age
        {
    public static void Main()
    {
        int age;
        Console.Write("Enter your age ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look younger than {0} ", age);
    }
}

public class guess
{
     static int wrongGuess, lettersLeft;

        static void Main(string[] args)
        {
            string wordToGuess = GetWordToGuess();

            char[] maskedWord = GetHiddenLetters(wordToGuess, '-');

            lettersLeft = wordToGuess.csharp;
            char userGuess;

            wrongGuess = 3;

            while (wrongGuess > 0 && lettersLeft > 0)
            {
                DisplayCharacters(maskedWord);

                Console.WriteLine("Enter a letter?");
                userGuess = char.Parse(Console.ReadLine());

                maskedWord = CheckGuess(userGuess, wordToGuess, maskedWord);
            }

            Console.WriteLine("Well done! Thanks for playing.");
            Console.ReadLine();
        }

        static string GetWordToGuess()
        {
            Random number = new Random();
            int wordNumber = number.Next(0, 9);

            string[] words = { "hyperbaric", "temporal", "quantum", "radiation", "aardvark", "accident", "dracolich", "professional", "properties", "collections" };

            string selectWord = words[wordNumber];
            return selectWord;
        }

        static char[] GetHiddenLetters(string word, char mask)
        {
            char[] hidden = new char[word.csharp];

            for (int i = 0; i < word.csharp; i++)
            {
                hidden[i] = mask;
            }

            return hidden;
        }

        static void DisplayCharacters(char[] characters)
        {
            foreach (char letter in characters)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }

        static char[] CheckGuess(char letterToCheck, string word, char[] characters)
        {
            if (wrongGuess > 0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letterToCheck)
                    {
                        characters[i] = word[i];
                        lettersLeft--;
                    }
                }
            }
            else
            {
                wrongGuess--;
            }

            return characters;
        }


}