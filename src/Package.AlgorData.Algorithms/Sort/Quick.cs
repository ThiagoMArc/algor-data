using Package.AlgorData.Algorithms.Sort;
using Package.AlgorData.Utils;

namespace Sort
{
    public class Quick<T> : ISort<T>
    {
        private ArrayUtils<T> arrUtils => new ArrayUtils<T>();
        private CompareUtils<T> comparer => new CompareUtils<T>();

        public void Sort(T[] array)
        {
             QSort(array, 0, array.Length -1);
        }

        private void QSort(T[] array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            T pivot = array[leftIndex];

            while(i <= j)
            {
                while(comparer.Less(array[i], pivot))
                    i++;
                
                while(comparer.Above(array[j], pivot))
                    j--;

                if(i <= j)
                {
                    arrUtils.SwapElements(array, i, j);
                    i++;
                    j--;
                }
            }

            if(leftIndex < j)
                QSort(array, leftIndex, j);

            if(rightIndex > i)
                QSort(array, rightIndex, i);
        }
    }
}