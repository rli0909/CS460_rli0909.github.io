using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class QueueInterface<T>
    {
        Node head;
        Node tail;
        int count = 0;

        public void Enqueue(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                tail = tail.Next;
            }
            count++;
        }
        public int Dequeue()
        {
            if (head == null)
            {
                throw new QueueUnderflowException("Queue is Empty");
            }
            int result = _head.Data;
            head = head.Next;
            return result;
        }

        public boolean isEmpty()
        {
            if (head == null && tail == null)
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
