using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console properties
            Console.Title = "Anton Bielov Lesson 04 problem 3 Circulare queue";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            //Initialization
            Random inputValue = new Random();
            
            //Fill the queue
            while (!Enqueue(inputValue.Next(0, 999)))
            { print(); }

            //Return 5 elements
            for (int q = 0; q < 5; q++)
            {
                Console.WriteLine("Returned element = {0,10}", dequeue());
                print();
            }


      
            //Fill the queue again
            while (!Enqueue(inputValue.Next(0, 999)))
            { print(); }

            //for (int q = 0; q < 4; q++)
            //{
            //    enqueue(inputValue.Next(0, 888));
            //    print();
            //}
            for (int q = 0; q < 9; q++)
            {
                Console.WriteLine("Returned element = {0,10}", dequeue());
                print();
            }

            // Stop to show results
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(false);



        } // End of Program

        //enqueue - adding new element
        //dequeue - extracting eldest element
        //print   - visualizing content of internal array

        static int[] intQueue = new int[8];    // A body of the queue
        static int qHead, qTail;//, qLenth;       // indexses
        static bool Enqueue(int newElement)    // New enqueue method - returns true if success
        {
            bool qIsFull = ((qTail == 0) && (qHead == intQueue.Length) || (qTail != 0) && qHead==qTail);
            if (qIsFull) { return qIsFull;}
            else if (qHead == intQueue.Length) { qHead = 0; intQueue[qHead] = newElement; qHead++; }
            else {intQueue[qHead] = newElement; qHead++;}
                        
            return qIsFull;
        }
        //static void enqueue(int newElement)
        //{
        //    if ((qTail == qHead) && (qTail == 0) && (qLenth == 0))
        //    {
        //        intQueue[qHead] = newElement;
        //        qHead++;
        //        qLenth++;
        //    }
        //    else if ((qHead == qTail) || ((qHead == intQueue.Length) && (qTail == 0)))
        //    {
        //        Console.WriteLine("Queue is full!!!");
        //    }
        //    else if ((qHead == intQueue.Length) && (qTail != 0))
        //    {
        //        qHead = 0;
        //        qLenth++;
        //        intQueue[qHead] = newElement;
        //        qHead++;
        //    }
        //    else if (qHead < intQueue.Length)
        //    {
        //        intQueue[qHead] = newElement;
        //        qHead++;
        //        qLenth++;
        //    }
        //}
        static int dequeue()
        {
            int r;
            if ((qTail == qHead && qHead==0)||(qTail==(qHead-1)))
            {
                Console.WriteLine("Queue is empty!!!");
                return -1;
            }
            else if (qTail == intQueue.Length -1)
            {
                r = intQueue[qTail];
                //intQueue[qTail] = -1;
                qTail = 0;
                //qLenth--;
                return r;
            }
            else
            {
                r = intQueue[qTail];
                //intQueue[qTail] = -1;
                qTail++;
                //qLenth--;
                return r;
            }

        }
        static void print()
        {
            for (int i = 0; i < intQueue.Length; i++)
            {
                if (qHead > qTail && (i < qTail || i > qHead - 1))
                {
                    Console.Write(" FREE|");
                }
                else if (qHead < qTail && !(i > qTail - 1 || i < qHead))
                {
                    Console.Write(" FREE|");
                }
                //else if (qHead == qTail)
                //{
                //    Console.Write(" FREE|");
                //}
                else
                {
                    Console.Write("{0,5}|", intQueue[i]);
                }

            }
            Console.Write(">H={0,2}>T={1,2} \n", qHead, qTail);//, qLenth);
        }


    } //End of Main
} //EOF