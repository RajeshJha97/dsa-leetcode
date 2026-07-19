using Fundamentals.LinkedList.Nodes;

namespace Fundamentals.LinkedList;

internal class Circular
{
    public Node Head;
    public Node Tail;
    public int size;

    public Circular()
    {
        Head = null;
        Tail = null;
        size = 0;
    }

    public void AddAny(int data, int position)
    {
        Node newest = new Node(data, null);
        Node p = Head;
        int i = 1;

        while (i < position - 1)
        {
            p = p.Next;
            i++;
        }

        newest.Next = p.Next;
        p.Next = newest;
        size++;

    }
    public void AddFirst(int data)
    {
        Node newest = new Node(data, null);

        if (IsEmpty())
        {
            newest.Next = newest;
            Head = newest;
            Tail = newest;
        }
        else 
        {
            newest.Next = Head;
            Head = newest; ;
            Tail.Next = newest;
        }
        size++;
    }

    public void AddLast(int data)
    {
        Node newest = new Node(data, null);

        if (IsEmpty())
        {
            Head = newest;            
            Head.Next = newest;
        }
        else 
        {
            newest.Next = Tail.Next;
            Tail.Next = newest;
        }

        Tail = newest;
        size++;
    }

    public void Display()
    {
        Node p = Head;
        int i = 0;

        while (i < Length())
        {
            Console.Write(p.Data + " -->");
            p = p.Next;
            i++;
        }

        //while (true)
        //{
        //    Console.Write(p.Data + " -->");
        //    p = p.Next;

        //    if (p == Head)
        //    {
        //        break;
        //    }
        //}
        Console.WriteLine();
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int Length()
    {
        return size;
    }
}
