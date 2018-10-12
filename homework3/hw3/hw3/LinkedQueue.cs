using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }


        public bool isEmpty()
        {
            
            if (front == null && rear == null)
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
            throw new NotImplementedException();
        }

        public T push(T element)
        {
            throw new NotImplementedException();
        }
    }
}
