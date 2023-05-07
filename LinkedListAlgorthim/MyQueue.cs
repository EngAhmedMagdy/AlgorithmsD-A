using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAlgorthim
{
    // C# program to implement a queue using an array
    using System;
    using System.Globalization;

    public class MyQueue
    {
        private int front, rear, capacity;
        private int[] queue;

        public MyQueue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }

        // function to insert an element
        // at the rear of the queue
        public void queueEnqueue(int data)
        {
            if (front -1 == rear|| (front ==0 && rear == capacity -1 ))
            {
                return;
            }
            queue[rear] = data;
            if (capacity == rear)
            {
                rear = 0;
            }

            else
            {
                rear += front + 1;
            }                
            return;
         }

        // function to delete an element
        // from the front of the queue
        public int queueDequeue()
        {
            int x = queue[front];
                // if queue is empty
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
            }
            else
            {
                front++;
            }
            return x;
        }

        // print queue elements
        public void queueDisplay()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} <-- ", queue[i]);
            }
            return;
        }

        // print front of queue
        public void queueFront()
        {
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            Console.Write("\nFront Element is: {0}",
                        queue[front]);
            return;
        }
    }


    // This code has been contributed by 29AjayKumar

}
