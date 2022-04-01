using System;
using System.Collections;
using System.Collections.Generic;

namespace ColectionsHomeWork
{
    class Program
    { static bool InputNumber(Queue<int> newQueue)
        {
            Console.WriteLine("Insert numbers: ");
            int userInput;
            bool isNumber = int.TryParse(Console.ReadLine(), out userInput);
            if(isNumber)
            {
                newQueue.Enqueue(userInput);
         
            }
            if(!isNumber)
            {
                Console.WriteLine("This is not number please");
                return false;
            }
            Console.WriteLine("Whoul you do like to enter another number?? Press any key to fill the list or X to exit ");
            if (Console.ReadLine().ToLower() == "x")
                return true;
            return false;
        }
        static void iterateQueque(IEnumerable queque)
        {
            foreach(var queq in queque)
            {
                Console.WriteLine(queq);
            }
        }
        static void Main(string[] args)
        {
            Queue<int> newQueue = new Queue<int>();

            while (!InputNumber(newQueue));
            Console.WriteLine("====================================== The result is:");

            iterateQueque(newQueue);
            
            
            
        }
    }
}
