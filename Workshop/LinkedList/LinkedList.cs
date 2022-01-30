namespace Workshop.LinkedList;

public class LinkedList
{
    private int _dataCount;
    private ListNode _listNode;

    public LinkedList()
    {
        _dataCount = 0;
        _listNode = null;
    }

    public void AddToFront(int data)
    {
        var node = new ListNode(data)
        {
            Next = _listNode
        };

        _listNode = node;

        _dataCount++;
        Console.WriteLine($"Data Count : { _dataCount }");
    }

    public void ListLoop()
    {
        var node = _listNode;
        while (node != null)
        {
            Console.WriteLine($"     Data Value : { node.Data }");
            node = node.Next;
        }
    }
}