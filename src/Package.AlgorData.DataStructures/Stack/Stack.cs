using Shared;
namespace Package.AlgorData.DataStructures.Stack
{
    public class Stack<T>
    {
        private Node<T>? root;
        private int count = 0;

        public int Count => count;

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new(data);

            if (root == null)
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

            if (root == null)
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
        }

        public bool Contains(T element)
        {
            if (root == null)
            {
                return false;
            }

            return Search(element) != null;
        }

        private T? Search(T element)
        {
            var currentElement = root;

            while (currentElement != null)
            {
                if (Comparer<T>.Default.Compare(currentElement.Data, element) == 0)
                {
                    return currentElement.Data;
                }

                currentElement = currentElement.Next;
            }

            return default;
        }
    }
}