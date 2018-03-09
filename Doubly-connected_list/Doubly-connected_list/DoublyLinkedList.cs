using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_connected_list
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if(head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if(count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }

        public bool Remove(T data)
        {
            DoublyNode<T> cur = head;

            while(cur != null)
            {
                if (cur.Data.Equals(data))
                {
                    break;
                }
                cur = cur.Next;
            }
            if(cur != null)
            {
                if(cur.Next != null)
                {
                    cur.Next.Previous = cur.Previous;
                }
                else
                {
                    tail = cur.Previous;
                }
                if(cur.Previous != null)
                {
                    cur.Previous.Next = cur.Next;
                }
                else
                {
                    head = cur.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> cur = head;
            while(cur != null)
            {
                if (cur.Data.Equals(data))
                {
                    return true;
                }
                cur = cur.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> cur = head;
            while(cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;
            }
        }
        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> cur = tail;
            while(cur != null)
            {
                yield return cur.Data;
                cur = cur.Previous;
            }
        }
    }
}
