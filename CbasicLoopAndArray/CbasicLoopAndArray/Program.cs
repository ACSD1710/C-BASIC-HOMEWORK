using System;

namespace CbasicLoopAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ///////////////// EXERCISE 6 NADOPOLNUVAWE //////////////////
            #region Exercise 6 nadopolnuvawe
            /* string[] nameArray = new string[1];

             for (int i = 0; i <= nameArray.Length - 1; i++)
             {
                 Console.WriteLine("Please enter a Name: ");
                 nameArray[i] = Console.ReadLine();

                 Console.WriteLine("Do you like to add another Name Y or N");
                 string userInput = Console.ReadLine();
                 if (userInput.ToUpper() == "N")
                 {
                     Console.WriteLine("Its Wooork!!!!!!");
                     break;
                 }
                 else if (userInput.ToUpper() == "Y")
                 {
                     int counter = 2 + i;
                     Array.Resize(ref nameArray, counter);
                     continue;
                 }
                 else
                 {
                     Console.WriteLine("Its Wooork!!!!!!");
                     break;
                 }
             }

             foreach (string name in nameArray)
             {
                 Console.WriteLine(name);
             }*/
            #endregion
            ///////////////// EXERCISE 1 //////////////////
            #region EXERCISE 1
            /*int[] inputArray = new int[6];
            int evenSum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                inputArray[i] = int.Parse(Console.ReadLine());

                if (inputArray[i] % 2 == 0)
                {
                    evenSum += inputArray[i];
                    continue;

                }
            }
            Console.WriteLine("The result is " + evenSum);
*/
            #endregion
            ///////////////// EXERCISE 2 //////////////////
            #region Exercise 2
            string[] g1Array = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] g2Array = { "Darko", "Marko", "Zarko", "Mirko", "Svirko" };


            string answer;

            while (true)
            {

                Console.WriteLine("Which group you like to print, chose G1 or G2 student group");
                answer = Console.ReadLine();

                if (answer.ToLower() == "g1" || answer.ToLower() == "g2")
                {
                    break;
                }
            }

            if (answer.ToLower() == "g1")
            {
                Console.WriteLine("The Students in G1 are: ");
                foreach (string name in g1Array)
                {
                    Console.WriteLine(name);
                }
            }
            if (answer.ToLower() == "g2")
            {
                Console.WriteLine("The Students in G2 are: ");
                foreach (string name in g2Array)
                {
                    Console.WriteLine(name);
                }

            }
            #endregion
            Console.ReadLine();
        }
    }
}
