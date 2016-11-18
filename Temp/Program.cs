using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console properties it is cool :)
            Console.Title = "Anton Bielov Lesson 04";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            //Initialize variables
            int ArrLength;
            int ArrMin = 0;
            int ArrMax = 0;
            int[] InputArray;

            ArrLength = ReadValue("Enter the table lenth > ");
            InputArray = new int[ArrLength];

            for (int index = 0; index < ArrLength; index++)
            {//Enter array's values
                InputArray[index] = ReadValue("Enter array value > ");
                if (index == 0)
                {   //Initialization of min-max selection
                    //Before computation of min and max values set both equail to first array element.
                    ArrMin = InputArray[0];
                    ArrMax = InputArray[0];
                }
                else
                {// Other cycles are applicable for checking min and max values
                    if (ArrMin > InputArray[index])
                    { ArrMin = InputArray[index]; }
                    if (ArrMax < InputArray[index])
                    { ArrMax = InputArray[index]; }
                }
            }
            // Display the results
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Array length = {0}, Min = {1}, Max = {2}", ArrLength, ArrMin, ArrMax);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(false);
        }
        static int[] Swap(int[] ProcessingArr, int a, int b)
        //Method for swappintg of two elements in array
        {
        int[] temp;
            temp = new int[3];
            temp = ProcessingArr;
        return temp[];
        }
        static int ReadValue(string Caption)
        //Repitiatly reads values and returns last entered int;
        {
            int RetNumber;
            Console.Write(Caption);
            while (!int.TryParse(Console.ReadLine(), out RetNumber))
            {
                Console.WriteLine("Entered value is not Integer, please try again");
                Console.Write(Caption);
            }
            return RetNumber;
        }
    }
}
