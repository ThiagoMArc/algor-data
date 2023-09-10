using Shared;
namespace Package.AlgorData.DataStructures.Stack
{
    public class Stack<T>
    {
        private Node<T>? root;
        private static LinkedListUtils<T> utils => new();
        private int count = 0;

        public int Count => count;

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new(data);

            if (IsEmpty())
            {
                root = newNode;
            }
            else
            {
                Node<T> temp = root;
                root = newNode;
                newNode.Next = temp;
            }

            count++;
        }

        public T Pop()
        {
            T topElement;

            if (IsEmpty())
            {
                throw new InvalidOperationException("Can not Pop Empty Stack");
            }

            topElement = root.Data;
            root = root.Next;
            count--;

            return topElement;
        }

        public T Peek()
        {
            T topElement;

            if (root == null)
            {
                throw new InvalidOperationException("Can not Peek From Empty Stack");
            }

            topElement = root.Data;

            return topElement;
        }

        public void Clear()
        {
            root = null;
            count = 0;
        }

        public bool Contains(T element)
        {
            return root != null && Stack<T>.utils.Search(element, root) != null;
        }
    }
}