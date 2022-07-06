namespace Package.AlgorData.DataStructures.Stack;
public class Stack<T>
{
    private StackNode<T>? root;

    public bool IsEmpty()
    {
        return root == null;
    }

    public void Push(T data)
    {
        StackNode<T> newNode = new StackNode<T>(data);

        if (root == null)
        {
            root = newNode;
        }
        else
        {
            StackNode<T> temp = root;
            root = newNode;
            newNode.Next = temp;
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
        if(root == null)
        {
            return false;
        }

        var queriedElement = Search(element);

        return queriedElement != null;
    }

    internal T? Search(T element)
    {
        var currentElement = root;

        while(currentElement != null)
        {
            if(Comparer<T>.Default.Compare(currentElement.Data, element)  == 0)
            {
                return currentElement.Data;
            }

            currentElement = currentElement.Next;
        }

        return default;
    }

}
