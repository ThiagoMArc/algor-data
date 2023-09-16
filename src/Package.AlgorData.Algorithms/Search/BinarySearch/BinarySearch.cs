namespace Package.AlgorData.Algorithms.Search.BinarySearch
{
    public class BinarySearch<T>
    {
        public int IndexOf(T[] arr, T element)
        {
            if(arr is null)
                throw new InvalidOperationException("Can not peform search on null array");

            int left = 0;
            int right = arr.Length;
            while (left < right)
            {
                int middle = (right - left) / 2 + left;
                int compare = Comparer<T>.Default.Compare(arr[middle], element);

                if (compare == 0)
                    return middle;
                else if(compare > 0)
                    left += 1;
                else
                    right -= 1;
            }

            return -1;
        }
    }
}