using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithShifting
{
    public class PriorityQueue
    {
        public int[] queue;
        public int size;
        public int front;
        public int rear;

        public PriorityQueue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            queue = new int[sizeOfQueue];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");
            }
            else
            {
                rear++;
                queue[rear] = item;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                int maxIndex = 0;
                int max = queue[0];
                for (int i = front + 1; i <= rear; i++)
                {
                    if (max < queue[i])
                    {
                        max = queue[i];
                        maxIndex = i;
                    }
                }

                Console.WriteLine(queue[maxIndex]);
                rear--;

                int j = maxIndex;
                for (int i = maxIndex + 1; i <= rear; i++)
                {
                    queue[j] = queue[i];
                    j++;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
            }

            for (int i = front + 1; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }

        public bool IsEmpty()
        {
            if (rear == -1 || front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((rear + 1) == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
