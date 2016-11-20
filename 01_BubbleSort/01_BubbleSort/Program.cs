using System;
using System.Collections.Generic;
using System.Text;

namespace _01_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console properties, just for curiosity
            Console.Title = "Anton Bielov Lesson 04 problem 1 Bubble Sorting";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            //array initialisation
            int[] intArray = { 33, 3, 8, 3,-1, 0, 1, 4, 6, 9 };
            WriteArray(intArray, "Input array");
            //bubble sorting section
            bubbleSorting(intArray);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteArray(intArray, "Sorted ==>");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(false);
            }
        //End of main --------------------------------------------

            static void bubbleSorting(int[] inputArray)
            //Bubble sorting method for interger array
        {
                bool elementsNotSwapped = true;
                while (elementsNotSwapped)
                //Sort untill no sapping is present
                {
                    elementsNotSwapped = false;
                    int n = 0;
                    do
                    {
                        if (inputArray[n] > inputArray[n + 1])
                        {
                            swapElements(inputArray, n + 1, n);
                            WriteArray(inputArray, "Bubbled ==>");
                            elementsNotSwapped = true;
                        }
                        n++;
                    }
                    while (n < inputArray.Length - 1);
                }

            }
       static int[] swapElements(int[] inputArray, int indexA, int indexB)
          //method for swapping elements in array
        {
            int accumulator = inputArray[indexB];
            inputArray[indexB] = inputArray[indexA];
            inputArray[indexA] = accumulator;
            return inputArray;
        }
        static void WriteArray (int[] inputArray, string caption)
           //method for user friendly outut array of integer
            {
                int totalLength = caption.Length + 3 + inputArray.Length * 4;

                Console.Write("|{0,2} >", caption);
                for (int i = 0; i < inputArray.Length; i++)
                {
                    Console.Write("{0,3}|", inputArray[i], i);
                }
                Console.WriteLine("");
                for (int i = 0; i < totalLength; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }
    }
}