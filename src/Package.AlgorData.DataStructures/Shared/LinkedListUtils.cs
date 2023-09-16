namespace Package.AlgorData.DataStructures.Shared
{
    public class LinkedListUtils<T>
    {
        public T? Search(T element, Node<T> node)
        {
            var currentElement = node;

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