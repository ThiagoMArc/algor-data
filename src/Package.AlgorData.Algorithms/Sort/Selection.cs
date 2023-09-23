using Package.AlgorData.Utils;

namespace Package.AlgorData.Algorithms.Sort
{
    public class Selection<T> : ISort<T>
    {
        private ArrayUtils<T> arrUtils => new ArrayUtils<T>();

        public void Sort(T[]array)
        {
            int arraySize = array.Length;
            for (int i=0; i< arraySize; i++)
            {
                int min = i;
                for (int j=i+1; j< arraySize; j++)
                {
                    if(Comparer<T>.Default.Compare(array[j], array[min]) < 0)
                        min = j;
                }

                arrUtils.SwapElements(array, i, min);
            }

        }
    }
}