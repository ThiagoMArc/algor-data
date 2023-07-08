namespace Package.AlgorData.DataStructures.Stack
{
    public class Stack<T>
    {
        private StackNode<T>? root;
        private int count = 0;

        public int Count => count;

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Push(T data)
        {
            StackNode<T> newNode = new(data);

            if (root == null)
            {
                root = newNode;
                IncrementCount();
            }
            else
            {
                StackNode<T> temp = root;
                root = newNode;
                newNode.Next = temp;
                IncrementCount();
            }
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
            DecrementCount();

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

            var queriedElement = Search(element);

            return queriedElement != null;
        }

        internal T? Search(T element)
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

        internal void IncrementCount()
        {
            this.count++;
        }

        internal void DecrementCount()
        {
            this.count--;
        }

    }
}