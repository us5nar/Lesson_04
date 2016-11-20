using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console properties, just for curiosity
            Console.Title = "Anton Bielov Lesson 04, problem 2 Insertion Sorting";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            //Initialize variables
            //Array for insertion sorting  
            int[] intArray;
            intArray = new int[8] { 88, -2, 66, 1, 5, 0, 9, 2 };
            //Insertion sorting
            WriteArray(intArray, "Befor sorting");
            InsertionSort(intArray);
            //User friendly output
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteArray(intArray, "Sorted ==>");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(false);
        }//End of main ------------------------------------------------------------

        static void InsertionSort(int[] inputArray)
        // Insertion sorting method realization
        // Algorithm the next:
        // for i = 2:n,
        //    for (k = i; k > 1 and a[k] < a[k - 1]; k--) 
        //        swap a[k, k - 1]
        //  → invariant: a[1..i] is sorted
        //end
        // Still do not understand how it works.
        {
            int temp, j;
            for (int i = 1; i < inputArray.Length; i++)
            {
                temp = inputArray[i];
                j = i - 1;
                while (j >= 0 && inputArray[j] > temp)
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                    WriteArray(inputArray, "Insertion ");
                }
                inputArray[j + 1] = temp;
                WriteArray(inputArray, "Insertion ");
            }
        }
        static int[] swapElements(int[] inputArray, int indexA, int indexB)
        //method for swapping the elements in array
        {
            int accumulator = inputArray[indexB];
            inputArray[indexB] = inputArray[indexA];
            inputArray[indexA] = accumulator;
            return inputArray;
        }
        static void WriteArray(int[] inputArray, string caption)
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
    } // End of program
}
