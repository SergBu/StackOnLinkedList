using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnLinkedList
{
    public class StackOnLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        int count;

        public bool IsEmpty { get { return count is 0; } }
        public int Count { get { return count; } }
        public void Push(T data)
        {
            var node = new Node<T>(data);
            node.Next = head;
            head = node;
            count++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("stack is empty");
            }

            var data = head.Data;
            head = head.Next;
            count--;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("stack is empty");
            }

            return head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;

            while (current is not null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
