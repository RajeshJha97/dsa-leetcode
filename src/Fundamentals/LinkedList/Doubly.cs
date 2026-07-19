using Fundamentals.LinkedList.Nodes;
using System.Drawing;

namespace Fundamentals.LinkedList;

internal class Doubly
{
    private DNode _head;
    private DNode _prev;
    private DNode _tail;
    private int _size;

    public Doubly()
    {
        _head = null;
        _prev = null;
        _tail = null;
        _size = 0;
    }

    public void AddLast(int data)
    {
        DNode newest = new DNode(data);
        if (IsEmpty())
        {
            AddFirst(data);
        }
        else {
            newest.prev = _tail;
            _tail.next = newest;
            _tail = newest;
            _size++;
        }
    }

    public void AddFirst(int data)
    {
        DNode newest = new DNode(data);

        if (IsEmpty())
        {
            _head = newest;
            _prev = null;
            _tail = newest;
            _tail.next = null;
            _size++;
        }
        else { 
                    
            newest.next= _head;
            _head.prev = newest;
            _head = newest;
            _size++;
        }
    }

    public void AddAny(int data, int pos)
    {
        if (pos > _size)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Index out of range");
            Console.ResetColor();
            Console.WriteLine("Existing List...");
            return;
        }
        DNode newest=new DNode(data);
        if (pos == 1 || IsEmpty())
        {
            AddFirst(data);
        }
        else {
            DNode track = _head;

            for (int i =1; i < pos-1; i++)
            {
                track = track.next;
            }           
            newest.prev= track;
            newest.next = track.next;
            track.next = newest;
            _size++;
            Console.WriteLine(Length());
        }
    }

    public void Display()
    {
        DNode head= _head;
        for (int i = 1; i <= Length(); i++)
        {
            Console.Write(head.data + " --> ");
            head = head.next;
        }
        Console.WriteLine();
    }


    private bool IsEmpty()
    {
        return _size == 0;
    }

    public int Length()
    {
        return _size;
    }
}
