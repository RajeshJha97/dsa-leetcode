namespace Fundamentals.LinkedList.Nodes;

internal class DNode
{
    public int data;
    public DNode next;
    public DNode prev;

    public DNode(int data)
    {
        this.data = data;
        prev = null;
        next = null;
    }
}
