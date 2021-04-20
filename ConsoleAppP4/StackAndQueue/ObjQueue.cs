using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP4.StackAndQueue
{
    public class ObjQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int size;
        private int max;

        public ObjQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeue from queue");
                int p = ele[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", ele[front]);
                Console.WriteLine("Rear item is {0}", ele[rear]);
                return p;
            }
        }

        public void PrintQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for(int i = front; i <= rear; i++)
                {
                    Console.WriteLine(ele[i] + " enqueued to queue");
                }
            }
        }
    }
}