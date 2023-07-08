namespace Package.AlgorData.DataStructures.Stack
{
    public class StackNode<T>
    {
        public T Data;
        public StackNode<T>? Next;

        public StackNode(T Data) => this.Data = Data;
    }
}