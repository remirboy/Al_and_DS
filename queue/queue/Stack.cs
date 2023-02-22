using System;
using System.Collections;
using System.Collections.Generic;

namespace queue
{
    public class Stack<T> : IEnumerable<T>
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;

        // добавление в стек 
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        // удаление из стека
        public T Pop()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            tail = tail.Previous;
            count--;
            return output;
        }

        // получаем первый элемент
        public T Head
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }

        // получаем последний элемент
        public T Tail
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = tail;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Previous;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public Stack()
        {
        }
    }
}
