using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simply_connected_list
{
    class LinkedList<T> : IEnumerable<T> //simply-connected list
    {
        Generalized<T> head;//first element
        Generalized<T> tail;//last element
        int count; //count elements in list
        
        //add element
        public void Add(T data)
        {
            Generalized<T> gen = new Generalized<T>(data);

            if(head == null)
            {
                head = gen;
            }
            else
            {
                tail.Next = gen;
            }
            tail = gen;

            count++;
        }
        //delete element
        public bool Remove(T data)
        {
            Generalized<T> cur = head;
            Generalized<T> prev = null;

            while(cur != null)
            {
                if (cur.Data.Equals(data))
                {
                    //if data inside or end of list
                    if(prev != null)
                    {
                        //remove cur, prev ref on car.Next
                        prev.Next = cur.Next;

                        //if cur.Next = null, than prev = tail
                        if(cur.Next == null)
                        {
                            tail = prev;
                        }
                    }
                    //if remove first el, update value 'head'
                    else
                    {
                        head = head.Next;

                        if(head == null)
                        {
                            tail = null;
                        }                        
                    }
                    count--;
                    return true;
                }
                prev = cur;
                cur = cur.Next;
            }
            return false;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        //clear list
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //is element in list?
        public bool Constrain(T data)
        {
            Generalized<T> cur = head;
            while(cur != null)
            {
                if (cur.Data.Equals(data)){
                    return true;
                }
                cur = cur.Next;
            }
            return false;
        }
        //add begin
        public void AppendFirst(T data)
        {
            Generalized<T> gen = new Generalized<T>(data);
            gen.Next = head;
            head = gen;
            if(count == 0)
            {
                tail = head;
            }
            count++;
        }
        //display list
        public void Show()
        {
            Generalized<T> cur = head;
            while(cur != tail.Next)
            {
                Console.WriteLine(cur.Data.ToString());
                cur = cur.Next;
            }
        }
        //IEnumerable realization
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Generalized<T> cur = head;
            while(cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;
            }
        }
    }
}
