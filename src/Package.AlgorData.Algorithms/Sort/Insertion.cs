using Package.AlgorData.Utils;

namespace Package.AlgorData.Algorithms.Sort
{
    public class Insertion<T> : ISort<T>
    {
        private ArrayUtils<T> arrUtils => new ArrayUtils<T>();
        private CompareUtils<T> comparer => new CompareUtils<T>();

        public void Sort(T[] array)
        {
            int arraySize = array.Length;
            for(int i=1; i < arraySize; i++)
            {
                for(int j=i; j > 0 && comparer.Less(array[j], array[j-1]); j--)
                {
                    arrUtils.SwapElements(array, j, j-1);
                }
            }
        }

    }
}