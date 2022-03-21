using System;

namespace ConsoleApp2
{
    class Program
    {
        static void FunWithStrings(string input)
        {
            char[] myArr = input.ToCharArray();
            Array.Reverse(myArr);
            Console.WriteLine("1st Task: Reverse string: \n" + " - " + new string(myArr));
            Console.WriteLine("===============");
            int total = 0;
            string sentence = input.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("2nd Task: Print total number of vowels: \n" + " - " + "Stang have " + total + " vowels");
            Console.WriteLine("===============");
            string input1 = input.ToLower();
            int length = input1.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input1[i] != input1[length - i - 1])
                {
                    Console.WriteLine("3rd Task:Check if string is palindrome is: " + false);
                    break;
                }
                else
                {
                    Console.WriteLine("3rd Task:Check if string is palindrome is: " + true);
                    break;
                }

            }
            Console.WriteLine("===============");

            string str = input;

            str = str + " ";
            int len = str.Length;
            String k = " ", max = " ", min = " ";
            char ch;

            int p, max1 = 0;
            int min1 = len;

            for (int i = 0; i < len; i++)
            {
                ch = str[i];
                if (ch != ' ')
                {
                    k = k + ch;
                }
                else
                {
                    p = k.Length - 1;
                    if (p < min1)
                    {
                        min1 = p;
                        min = k;
                    }
                    if (p > max1)
                    {
                        max1 = p;
                        max = k;
                    }
                    k = " ";
                }
            }
            Console.WriteLine("4th Task:Print the largest word: Shortest Word = " + min + " Length of the Word = " + min1 + "\n");
            Console.WriteLine("5th Task:Print the largest word: Longest Word = " + max + " Length of the Word = " + max1);
            Console.WriteLine("===============");
            string str1;
            int i1, wrd, l;
            str1 = input;

            l = 0;
            wrd = 1;


            while (l <= str1.Length - 1)
            {

                if (str1[l] == ' ' || str1[l] == '\n' || str1[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("6th Task: Print the count of words is : {0}\n", wrd);
            Console.WriteLine("===============");

            String str2 = input;
            int[] charCount = new int[256];
            int length1 = str2.Length;
            for (int i = 0; i < length1; i++)
            {
                charCount[str2[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length1; i++)
            {
                if (maxCount < charCount[str2[i]])
                {
                    maxCount = charCount[str2[i]];
                    character = str2[i];
                }
            }
            Console.WriteLine("7th Task: Print the most used character (not space obviously) is: ");
            Console.WriteLine("The string is: " + str2);
            Console.WriteLine("The highest occurring character in the above string is: " + character);
            Console.WriteLine("Number of times this character occurs: " + maxCount);
        }
        static void RemoveExtraSpace(string input)
        {
            Console.WriteLine(String.Join(" ", input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)));

        }
        static void Main(string[] args)
        {

            FunWithStrings("Darko");
            RemoveExtraSpace("The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!");
            Console.WriteLine();
        }

    }
}
