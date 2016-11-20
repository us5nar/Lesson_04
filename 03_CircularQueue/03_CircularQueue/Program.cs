using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set console properties, just for curiosity
            Console.Title = "Anton Bielov Lesson 04 problem 3 Circulare queue";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            //Initialization
            Random inputValue = new Random();
            for (int q = 0; q < 9; q++)
            {
                enqueue(inputValue.Next(0, 999));
                print();
            }
            for (int q = 0; q < 5; q++)
            {
                Console.WriteLine("Returned element = {0,10}", dequeue());
                print();
            }
            for (int q = 0; q < 4; q++)
            {
                enqueue(inputValue.Next(0, 888));
                print();
            }
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

        //contains 3 methods:
        //enqueue - adding new element
        //dequeue - extracting eldest element
        //print   - visualizing content of internal array

        static int[] iQueue = new int[8];
        static int head, tail, CurrentQlenth; // indexses
        static void enqueue(int newElement)
        {
            if ((tail == head) && (tail == 0) && (CurrentQlenth == 0))
            {
                iQueue[head] = newElement;
                head++;
                CurrentQlenth++;
            }
            else if ((head == tail) || ((head == iQueue.Length) && (tail == 0)))
            {
                Console.WriteLine("Queue is full!!!");
            }
            else if ((head == iQueue.Length) && (tail != 0))
            {
                head = 0;
                CurrentQlenth++;
                iQueue[head] = newElement;
                head++;
            }
            else if (head < iQueue.Length)
            {
                iQueue[head] = newElement;
                head++;
                CurrentQlenth++;
            }
        }
        static int dequeue()
        {
            int r;
            if (tail == head)
            {
                Console.WriteLine("Queue is empty!!!");
                return -1;
            }
            else if (tail == iQueue.Length - 1)
            {
                r = iQueue[tail];
                iQueue[tail] = -1;
                tail = 0;
                CurrentQlenth--;
                return r;
            }
            else
            {
                r = iQueue[tail];
                iQueue[tail] = -1;
                tail++;
                CurrentQlenth--;
                return r;
            }

        }
        static void print()
        {
            for (int i = 0; i < iQueue.LongLength; i++)
            {
                if (head > tail && (i < tail || i > head - 1))
                {
                    Console.Write(" FREE|");
                }
                else if (head < tail && !(i > tail - 1 || i < head))
                {
                    Console.Write(" FREE|");
                }
                else if (head == tail)
                {
                    Console.Write(" FREE|");
                }
                else
                {
                    Console.Write("{0,5}|", iQueue[i]);
                }

            }
            Console.Write(">H={0,2}>T={1,2}>L={2,2} \n", head, tail, CurrentQlenth);
        }


    } //End of Main
} //EOF