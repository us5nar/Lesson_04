using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack demonstration");
            int[] arrayForSteck = new int[6] { 10, 20, 30, 40, 50, 60 };
//            MyStack intStack = new MyStack();
            Console.WriteLine("Peek from empty stack {0}", Peek());
            Console.WriteLine("Pop from empty stack {0}", Pop());
            for (int i = 0; i < 5; i++)
            {
                Push(arrayForSteck[i]);
            }
            Console.WriteLine("Peek from filled stack {0}", Peek());
            Console.ReadKey();
            Console.Clear();

        } //End of main



        //Stack API:
        //int Pop()
        //void Push(int value)
        //bool IsEmpty()
        //bool IsFull()
        //int Peek()
        static int marker = 0;
        static int size = 5;
        static int[] iArray = new int[6];// { 1, 3, 5, 7, 9 };
        static void Push(int inputValue)
        // incerts value to the stack
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!!!");
            }
            else
            {
                iArray[marker] = inputValue;
                marker++;
            }
        }
        static int Peek()
        //Returns current value
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!!!");
                return iArray[marker - 1];
            }
            else if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return iArray[marker];
            }

            //return iArray[marker];
        }
        static int Pop()
        //Returns current value and remove it from stack
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return iArray[marker];
            }
        }
        static bool IsEmpty()
        //Indicate if stack is empty
        {
            return (marker == 0);
        }
        static bool IsFull()
        //Indicate if stack is full
        { return marker == size; }

    }//End of Program
}
