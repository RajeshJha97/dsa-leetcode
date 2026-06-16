namespace Fundamentals;

internal class CustomLinkedList
{
    public Node Head;
    public Node Tail;
    public int Size;

    public CustomLinkedList()
    {
        Head = null;
        Tail = null;
        Size = 0;
    }

    public int Length()
    {
        return Size;
    }

    public bool IsEmpty()
    {
        return Size == 0;
    }

    public void AddLast(int data)
    {
        Node newest = new Node(data, null!);

        if (IsEmpty())
        {
            Head = newest;
        }
        else 
        {
            Tail.Next = newest;
        }
        Tail = newest;

        Size = Size + 1;
    }

    public void Display()
    {
        Node p = Head;

        while (p != null)
        {
            Console.Write(p.Data + "-->");
            p = p.Next;
        }
        Console.WriteLine();
    }
}

internal class Node
{
    public int Data;
    public Node Next;

    public Node(int data,Node next)
    {
        Data = data;
        Next = next;
    }
}
