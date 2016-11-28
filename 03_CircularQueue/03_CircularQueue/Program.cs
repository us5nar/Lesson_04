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
            qMaxLength = qBuffer.Length;
            qHead = 0;
            qTail = 0;
            qLength = 0;

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



        } //--------------------------------------- End of Program----------------------------------------------
//        Указатели хвоста и головы могут принимать любые значения от 0 до SIZE_BUF - 1. 
//Для работы с буфером требуется как минимум три функции – очистить буфер, положить символ, взять символ.

////"очищает" буфер
//void FlushBuf(void)
//        {
//            tail = 0;
//            head = 0;
//            count = 0;
//        }
//        Как вы видите, массив cycleBuf[] не очищается.Функция обнуляет "указатели" хвоста, головы и счетчик символов, но это равносильно тому, что в буфере нет данных.
//     //положить символ в буфер
//     void PutChar(unsigned char sym)
//        {
//            if (count < SIZE_BUF)
//            {   //если в буфере еще есть место
//                cycleBuf[tail] = sym;    //помещаем в него символ
//                count++;                    //инкрементируем счетчик символов
//                tail++;                           //и индекс хвоста буфера
//                if (txBufTail == SIZE_BUF) txBufTail = 0;
//            }
//        }

//        //взять символ из буфера
//        unsigned char GetChar(void)
//        {
//            unsigned char sym = 0;
//            if (count > 0)
//            {                            //если буфер не пустой
//                sym = cycleBuf[head];              //считываем символ из буфера
//                count--;                                   //уменьшаем счетчик символов
//                head++;                                  //инкрементируем индекс головы буфера
//                if (head == SIZE_BUF) head = 0;
//            }
//            return sym;
//        }
        //enqueue - adding new element
        //dequeue - extracting eldest element
        //print   - visualizing content of internal array

        static int[] qBuffer = new int[8];    // A body of the queue
        static int qHead, qTail, qLength, qMaxLength;   // indexses
        static bool qIsFull, qIsEmpty;
        static bool Enqueue(int newElement)           // New enqueue method - returns true if full
        {
            if (qLength < qMaxLength)
            {
                qBuffer[qTail] = newElement;
                qLength++;
                qTail++;
                qIsFull = false;

                if (qTail == qMaxLength) { qTail = 0; qIsFull = true; }
            }
            return qIsFull;
        }

        //-------------------------------------------------------------------------------------------------
        //public bool Enqueue(object obj)
        //{
        //    if ((qTail == (nMaxSize - 1) && qHead == 0) || ((qTail != -1) && (qTail + 1) == qHead))
        //        return false;
        //    if (qTail == (nMaxSize - 1) && qHead > 0)
        //        qTail = -1;
        //    qTail += 1;
        //    intQueue[qTail] = obj;
        //    if ((qTail - 1) == qHead &&
        //               intQueue[qHead] == null)
        //        qHead = qHead + 1;
        //    return true;
        //}
        //public object Dequeue()
        //{
        //    object Output = "Empty";
        //    if (intQueue[qHead] != null)
        //    {
        //        Output = intQueue[qHead];
        //        intQueue[qHead] = null;
        //        if ((qHead + 1) < nMaxSize &&
        //                intQueue[qHead + 1] != null)
        //            qHead += 1;
        //        else if (intQueue[0] != null && (qHead + 1) == nMaxSize)
        //            qHead = 0;
        //    }
        //    return Output;
        //}
        //-------------------------------------------------------------------------------------------------
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
            if ((qTail == qHead && qHead == 0) || (qTail == (qHead - 1)))
            {
                Console.WriteLine("Queue is empty!!!");
                return -1;
            }
            else if (qTail == qBuffer.Length - 1)
            {
                r = qBuffer[qTail];
                //intQueue[qTail] = -1;
                qTail = 0;
                //qLenth--;
                return r;
            }
            else
            {
                r = qBuffer[qTail];
                //intQueue[qTail] = -1;
                qTail++;
                //qLenth--;
                return r;
            }

        }
        static void print()
        {
            for (int i = 0; i < qBuffer.Length; i++)
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
                    Console.Write("{0,5}|", qBuffer[i]);
                }

            }
            Console.Write(">H={0,2}>T={1,2} \n", qHead, qTail);//, qLenth);
        }


    } //End of Main
} //EOF