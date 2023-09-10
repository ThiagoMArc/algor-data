using Shared;
namespace Package.AlgorData.DataStructures.Queue
{
    public class Queue<T>
    {
        private Node<T>? first;
        private Node<T>? last;
        private static LinkedListUtils<T> utils => new();
 
        private int count = 0;
        public int Count => count;

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(T data)
        {
            Node<T>? oldLast = last;

            last = new(data)
            {
                Next = null
            };

            if (IsEmpty()) 
                first = last;
            else
                oldLast.Next = last;
            
            count++;
        }

        public T Dequeue()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Can not Dequeue empty queue");

            T item = first.Data;
            first = first.Next;

            count--;
            return item;
        }

        public void Clear()
        {
            first = last = null;
            count = 0;
        }

        public bool Contains(T element)
        {
            return first != null && Queue<T>.utils.Search(element, first) != null;
        }
    }
}