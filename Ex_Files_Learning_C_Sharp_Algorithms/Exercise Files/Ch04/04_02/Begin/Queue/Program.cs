﻿using System;
using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue(5);
            myQueue.insert(100);
            myQueue.insert(10);
            myQueue.insert(20);
            myQueue.insert(30);
            myQueue.veiw();

            Console.WriteLine($"Front of the  queue is {myQueue.peekFront()} ");

            Console.WriteLine("About to remove item from queue");
            myQueue.remove();

            Console.WriteLine($"Front of the  queue is {myQueue.peekFront()} ");

        }
    }
    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }
        public void insert(long j)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }
        public long remove()
        {
            long temp = myQueue[front];
            front++;

            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }
        public long peekFront()
        {
            return myQueue[front];
        }
        public bool isEmpty()
        {
            return (items == 0);
        }
        private bool isFull()
        {
            return (items == maxSize);
        }
        public void veiw()
        {
            Console.Write("[");
            foreach (var q in myQueue)
            {
                Console.Write($"{q} ");
            }
            Console.WriteLine("]");
        }
    }
}
