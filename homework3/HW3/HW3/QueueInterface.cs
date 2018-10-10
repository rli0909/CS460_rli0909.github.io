using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    /**
     * A FIFO queue interface. This ADT is suitable for a singly 
     * linked queue.
     */
    class QueueInterface<T>
    {
        Node head;
        Node tail;
        int count;
        /**
         * Add an element to the rear of the queue
         * 
         * @return the element that was enqueued
         */
        public void push(T data){
            Node newNode = new Node(data);
            if(head == null){
                head = newNode;
                tail = head;
            }else{
                tail.next = newNode;
                tail = tail.next;
            }
            count++;
        }

        /**
         * Remove and return the front element.
         * 
         * @throws Thrown if the queue is empty
         */
        public int pop(){
            if(head == null){
                throw new QueueUnderflowException("Queue is Empty");
            }
            int result = head.data;
            head = head.next;
            return result;
        }

        /**
         * Test if the queue is empty
         * 
         * @return true if the queue is empty; otherwise false
         */
        public boolean isEmpty(){
            if(head == null && tail == null){
                return true;
            }else{
                return false;
            }
        }
    }
}
