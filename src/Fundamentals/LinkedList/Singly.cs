using Fundamentals.LinkedList.Nodes;

namespace Fundamentals.LinkedList;

internal class Singly
{
    public Node? Head;
    public Node? Tail;
    public int Size;

    public Singly()
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

    public void AddFirst(int data)
    {
        Node newest = new Node(data,null!);

        if (IsEmpty())
        {   Head = newest;
            Tail = newest;
         
        }
        else
        {
            newest.Next = Head!;
            Head = newest;
        }
        Size = Size + 1;

    }

    public void AddAny(int data, int position)
    {
        Node newest=new Node(data,null!);

        if (position > Size)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Index out of range");
            Console.ResetColor();
            Console.WriteLine("Existing List...");
            return;
        }

        if (IsEmpty())
        {
            Head = newest;
            Tail = newest;
        }
        else
        {
            Node p = Head;
            int positionNavigator = 1;

            while (positionNavigator < position - 1)
            {
                p = p.Next;
                positionNavigator++;
            }

            newest.Next = p.Next;
            p.Next = newest;
        }
        Size=Size + 1;
    }

    public void RemoveFirst()
    {
        if (IsEmpty())
        {
            return;
        }

        if (Size == 1)
        {
            Head = null;
            return;
        }
        Head = Head.Next;
        Size=Size - 1;
    }

    public void RemoveLast()
    {
        Node p = Head!;
        int i = 1;
        while (i < Size-1)
        {
            p = p.Next;
            i++;
        }
        Tail = p;
        p = p.Next;
        Tail!.Next = null!;
        int removedData = p.Data;
        Size--;
        Console.WriteLine("Removed: " + removedData);

    }

    public void RemoveAny(int position)
    {
        Node p = Head;
        int i = 1;

        while (i < position-1)
        {
            p = p.Next;
            i++;
        }

        int removedElement = p.Next.Data;
        p.Next = p.Next.Next;
        Size= Size - 1;
    }
    public void Display()
    {
        Node p = Head!;

        while (p != null)
        {
            Console.Write(p.Data + "-->");
            p = p.Next;
        }
        Console.WriteLine();
    }
}
