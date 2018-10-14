using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> Front;
        private Node<T> Rear;

        public LinkedQueue()
        {
            Front = null;
            Rear = null;
        }


        public bool isEmpty()
        {
            
            if (Front == null && Rear == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T pop()
        {
            T tmp = default(T);

            if (isEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when pop was invoked.");
            }
            else if (Front == Rear)
            {
                tmp = Front.data;
                Front = null;
                Rear = null;
            }
            else
            {
                tmp = Front.data;
                Front = Front.next;
            }
            return tmp;
        }

        public T push(T element)
        {
            if (element == null)
            {
                throw new NullReferenceException();
            }

            if (isEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                Rear.next = tmp;
                Rear = tmp;
            }

            return element;
        }
    }
}
