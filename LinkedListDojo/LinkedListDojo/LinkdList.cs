using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class LinkdList
    {
        private Node head;
        private Node last;
        private Node current;
        private int count;

        public int Count { get => count; private set =>  count = value; }

        public LinkdList()
        {
            head = new Node();
            current = head;
        }

        public void Add(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            newNode.Previous = current;
            current = newNode;
            Count++;

        }
        public void Insert(int index, object data)
        {
            Node temp = head.Next;

            for (int i = 0; i < count; i++)
            {
                if (i.Equals(index))
                {
                    //temp
                }
            }
        }

        public void Remove(object data)
        {
            Node temp = head.Next;
            
            for (int i = 0; i < Count; i++)
            {
                if (temp.Value.Equals(data))
                {
                    temp.Previous.Next = temp.Next;
                    Count--;
                } else
                {
                    temp = temp.Next;
                }
            }
        }

        public object Get(object data)
        {
            Node temp = head.Next;

            for (int i = 0; i < Count; i++)
            {
                if (temp.Value.Equals(data))
                {
                    return temp.Value;
                }
                else
                {
                    temp = temp.Next;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string tempString = "";
            Node tempNode = head.Next;
            for (int i = 0; i < Count; i++)
            {
                tempString += tempNode.Value + " ";
                tempNode = tempNode.Next;
            }
            return tempString;
        }
        
    }
}
