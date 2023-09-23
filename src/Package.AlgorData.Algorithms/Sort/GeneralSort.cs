namespace Package.AlgorData.Algorithms.Sort
{
    public class GeneralSort<T>
    {
        private ISort<T> sort;

        public GeneralSort(ISort<T> sort)
        {
            this.sort = sort;
        }

        public void Sort(T[] array)
        {
            sort.Sort(array);
        }
    }
}

