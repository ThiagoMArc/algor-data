namespace Package.AlgorData.Utils
{
    public class CompareUtils<T>
    {
        public bool Less(T first, T second)
        {
            return Comparer<T>.Default.Compare(first, second) < 0;
        }
    }
}