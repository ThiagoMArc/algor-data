namespace Package.AlgorData.Utils
{
    public class ArrayUtils<T>
    {
        public void SwapElements(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}